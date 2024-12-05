using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

// Пространство имен и имя класса
namespace UsersGraphics
{
    // Определение класса Form1, который представляет основную форму приложения
    public partial class Form1 : Form
    {
        // Поля для хранения данных изображения, параметров и настроек
        private ushort[,] imageArray;  // Двумерный массив для хранения изображения
        private int width;              // Ширина изображения
        private int height;             // Высота изображения
        private int shift;              // Сдвиг кода цвета
        private Color[] colorsArray;    // Массив цветов
        private int bufferSize = 8192; //Размер буфера для чтения изображения
        private Bitmap displayBitmap;    // Изображение для отображения
        private Bitmap ZoomBitmap;
        private Graphics gThumbnail;
        private byte color;
        private byte[] segmentValues = new byte[9];
        private Pen pen = new Pen(Color.Red, 2);
        private int Xmin, Ymin, Xmax, Ymax;
        private ushort minColor, maxColor, k;// переменные для интерполяции
        private double coefficient;

        private bool isZoom = false;
        private byte[] newColors = new byte[1024]; // Массив обновлённых цветов, полученных нелинейным преобразованием

        //Массив расстояний между сегментами по x
        private ushort[] segmentGaps =
        {
            0,
            128,
            256,
            384,
            512,
            640,
            768,
            896,
            1023
        };

        // Конструктор класса Form1
        public Form1()
        {
            // Инициализация компонентов формы
            InitializeComponent();

            // Инициализация массива цветов
            colorsArray = Enumerable.Range(0, 256)
                                    .Select(i => Color.FromArgb(i, i, i))
                                    .ToArray();
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 4;
            thumbnailPicturebox.Visible = false;
            gThumbnail = thumbnailPicturebox.CreateGraphics();


            chart1.Series["Brightness"].BorderWidth = 6;
            chart1.ChartAreas[0].AxisX.Maximum = 1023;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 255;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            radioButton3.Checked = true;

        }

        // Обработчик события загрузки изображения
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // Открытие диалога выбора файла изображения
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadImage(openFileDialog.FileName);
                }
            }
        }

        // Метод для загрузки изображения из файла
        private void LoadImage(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    // Чтение ширины и высоты
                    width = reader.ReadUInt16();
                    height = reader.ReadUInt16();

                    // Создание двумерного массива для хранения пикселей
                    imageArray = new ushort[height, width];

                    // Буфер для чтения пикселей
                    byte[] pixelBuffer = new byte[bufferSize]; // Размер буфера, можно настроиться
                    int bytesRead;
                    int totalPixels = height * width;
                    int index = 0;

                    // Чтение пикселей по частям
                    while (index < totalPixels)
                    {
                        // Вычисляем оставшиеся пиксели и правильно настраиваем размер буфера
                        int pixelsToRead = Math.Min(pixelBuffer.Length / sizeof(ushort), totalPixels - index);
                        bytesRead = fs.Read(pixelBuffer, 0, pixelsToRead * sizeof(ushort));

                        for (int i = 0; i < bytesRead / sizeof(ushort); i++)
                        {
                            int y = (index + i) / width; // Определение индекса по высоте
                            int x = (index + i) % width; // Определение индекса по ширине
                            imageArray[y, x] = BitConverter.ToUInt16(pixelBuffer, i * sizeof(ushort));
                        }

                        index += bytesRead / sizeof(ushort);
                    }
                }

                // Создание и отображение Bitmap изображения
                displayBitmap = CreateDisplayBitmap();
                mainPicturebox.Image = displayBitmap;
                mainPicturebox.Size = new Size(width, height);

                // Отображение информации о файле
                labelFilePath.Text = Path.GetFileName(filePath);
                labelSize.Text = $"Размер: {width}x{height}";

                // Инициализация сдвига кода
                shift = 0;
                radioButton0.Checked = true;

                // Настройка прокрутки
                vScrollBar.Maximum = mainPicturebox.Image.Height - panelCentral.Height / 2 + vScrollBar.LargeChange;
                vScrollBar.Minimum = panelCentral.Height / 2;
                vScrollBar.Value = vScrollBar.Minimum;
                scrollStepBox.Text = $"{vScrollBar.SmallChange}";
                textBoxPixel.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // обновление яркостей для конкретного сегмента
        private void updateNonLinearColors(int m)
        {
            byte y1, y2;
            ushort x1, x2;

            y1 = segmentValues[m];
            x1 = segmentGaps[m];

            y2 = segmentValues[m + 1];
            x2 = segmentGaps[m + 1];

            for (ushort x = x1; x < x2; x++)
            {
                newColors[x] = (byte)(y1 + ((x - x1) * (y2 - y1)) / (x2 - x1));
            }
        }
        
        // создание bitmap для mainPicturebox
        private Bitmap CreateDisplayBitmap()
        {
            Bitmap bitmap = new Bitmap(width, height);

                for (int y = 0; y < height; y++)
                    {
                    for (int x = 0; x < width; x++)
                    {
                    byte pixelValue = (byte)(imageArray[y, x] >> shift);

                    bitmap.SetPixel(x, y, colorsArray[pixelValue]);
                    }
                }
            

            return bitmap;
        }

        // Обработчик события прокрутки vScrollBar
        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            // Изменение позиции PictureBox в соответствии с положением полосы прокрутки
            int newY = -Math.Max(vScrollBar.Value, vScrollBar.Minimum) + vScrollBar.Minimum;
            mainPicturebox.Location = new Point(mainPicturebox.Location.X, newY);
            textBoxPixel.Text = $"{-mainPicturebox.Location.Y}";


        }

        // Обработчики событий MouseMove для панелей
        private void UpdateMouseMoveLabel(MouseEventArgs e, int yOffset = 0)
        {
            labelCoordinate.Text = $"Координаты X: {e.X} Y: {e.Y + yOffset}";
            labelColor.Text = "Яркость: наведите курсор на изображение";
        }

        // Обработчики событий изменения сдвига кода цвета
        private void UpdateShiftAndImage(int newShift)
        {
            shift = newShift;
            if (imageArray != null)
            {
                mainPicturebox.Image = CreateDisplayBitmap();
            }
        }

        private void radioButton0_CheckedChanged(object sender, EventArgs e)
        {
            UpdateShiftAndImage(0);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) => UpdateShiftAndImage(1);
        private void radioButton2_CheckedChanged(object sender, EventArgs e) => UpdateShiftAndImage(2);

        // Обработчик события нажатия кнопки "Задать" (прокрутка к определенному пикселю)
        private void buttonPixel_Click(object sender, EventArgs e)
        {
            try
            {
                // Изменение положения PictureBox на указанный пиксель
                if (Convert.ToInt32(textBoxPixel.Text) >= 0 || Convert.ToInt32(textBoxPixel.Text) <= height - vScrollBar.ClientSize.Height)
                    mainPicturebox.Location = new Point(mainPicturebox.Location.X, -Convert.ToInt32(textBoxPixel.Text));
                vScrollBar.Value = Math.Max(Convert.ToInt32(textBoxPixel.Text), vScrollBar.Minimum);
            }
            catch
            {
                MessageBox.Show(" Введено неверное значение.\n Значение должно быть от 0 до " + (height - vScrollBar.ClientSize.Height) + ". ");
                mainPicturebox.Location = new Point(mainPicturebox.Location.X, 0);
                vScrollBar.Value = vScrollBar.Minimum;
            }
        }

        // Обработчик события нажатия кнопки "Задать" (шаг прокрутки)
        private void buttonScrollStep_Click(object sender, EventArgs e)
        {
            try
            {
                int stepValue = Convert.ToInt32(scrollStepBox.Text);
                if (stepValue <= width && stepValue >= 1)
                {
                    vScrollBar.Maximum = mainPicturebox.Image.Height - panelCentral.Height / 2 + 10 + stepValue;
                    vScrollBar.SmallChange = stepValue;
                    vScrollBar.LargeChange = stepValue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введено неверное значение.\nЗначение должно быть от 1 до " + width + ".");

                    vScrollBar.Maximum = mainPicturebox.Image.Height - panelCentral.Height / 2 + 10;
                    vScrollBar.SmallChange = 1;
                    vScrollBar.LargeChange = 1;
                    scrollStepBox.Text = "1";


            }
        }

        // Обработчик события изменения значения trackBar
        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            mainPicturebox.Invalidate();
        }

        // Обработчик события покидания мыши PictureBox
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            mainPicturebox.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        // Обработчик события перемещения мыши над PictureBox
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mainPicturebox.Image != null)
            {
                labelCoordinate.Text = $"Координаты X: {e.X} Y: {e.Y}";
                labelColor.Text = $"Яркость: {imageArray[e.Y, e.X]}";

                CreateZoomBitmap(e.X, e.Y);
                mainPicturebox.Refresh();
            }
        }

        void generateThumbnailBitmap()
        {
            double scaleFactor = width / (double)thumbnailPicturebox.Width;

            int thumbnailWidth = thumbnailPicturebox.Width;
            int thumbnailHeight = (int)(height / scaleFactor);

            Bitmap thumbnailBitmap = new Bitmap(thumbnailWidth, thumbnailHeight);

            byte minBrightness = 255;
            byte maxBrightness = 0;
            byte[][] brightnessValues = new byte[thumbnailHeight][];

            for (short y = 0; y < thumbnailHeight; y++)
            {
                brightnessValues[y] = new byte[thumbnailWidth];
                for (short x = 0; x < thumbnailWidth; x++)
                {
                    int pixelSum = 0;
                    short xMax = (short)(x * scaleFactor + scaleFactor);
                    short yMax = (short)(y * scaleFactor + scaleFactor);

                    for (ushort pixelX = (ushort)(x * scaleFactor); pixelX < xMax; pixelX++)
                    {
                        for (ushort pixelY = (ushort)(y * scaleFactor); pixelY < yMax; pixelY++)
                        {
                            pixelSum += imageArray[pixelY, pixelX];
                        }
                    }

                    brightnessValues[y][x] = (byte)(pixelSum / (scaleFactor * scaleFactor));
                    if (brightnessValues[y][x] < minBrightness) minBrightness = brightnessValues[y][x];
                    if (brightnessValues[y][x] > maxBrightness) maxBrightness = brightnessValues[y][x];
                }
            }

            double brightnessScale =(maxBrightness - minBrightness)/255;

            byte adjustedColor;

            for (int x = 0; x < thumbnailWidth; x++)
            {
                for (int y = 0; y < thumbnailHeight; y++)
                {
                    adjustedColor = (byte)((brightnessValues[y][x] - minBrightness) / brightnessScale);
                    thumbnailBitmap.SetPixel(x, y, colorsArray[adjustedColor]);
                }
            }

            thumbnailPicturebox.Image = thumbnailBitmap;
        }

        private void thumbnailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (displayBitmap != null)
            {
                if (thumbnailCheckBox.Checked)
                {
                    mainPicturebox.Visible = false;
                    vScrollBar.Visible = false;
                    // Отображение миниатюры
                    thumbnailPicturebox.Visible = true;

                    generateThumbnailBitmap();
                }
                else
                {
                    // Скрытие миниатюры
                    thumbnailPicturebox.Visible = false;
                    mainPicturebox.Visible = true;
                    vScrollBar.Visible = true;
                }
            }
            else 
            { 
                
                thumbnailCheckBox.Checked = false;
                MessageBox.Show("Загрузите изображение");
            }

        }

        private void pictureBox_drawRedSquare(object sender, PaintEventArgs e)
        {
            if (isZoom) {
                e.Graphics.DrawRectangle(pen, Xmin, Ymin, Xmax - Xmin, Ymax - Ymin);
            }


        }

        private void CreateZoomBitmap(int LocationX, int LocationY)
        {
            // Получаем уровень увеличения из значения ползунка
            //byte minColor, maxColor, k;
            k = (ushort)trackBar1.Value;

            // Рассчитываем половину стороны увеличенной области
            int dX = pictureBoxZoom.Width / (k * 2);

            // Вычисляем граничные координаты ограничивающего прямоугольника
            Xmin = (short)(LocationX - dX); Ymin = (short)(LocationY - dX);
            Xmax = (short)(LocationX + dX); Ymax = (short)(LocationY + dX);

            // Проверяем и корректируем координаты, чтобы остаться внутри изображения
            if (Xmin < 0) { Xmax -= Xmin; Xmin = 0; }
            if (Ymin < 0) { Ymax -= Ymin; Ymin = 0; }
            if (Xmax >= width) { 
                Xmin -= Xmax - width; Xmax = width; }
            if (Ymax >= height) { Ymin -= Ymax - height; Ymax = height; }

            // Создаем новое изображение (Bitmap) для увеличенной области
            ZoomBitmap = new Bitmap((Xmax - Xmin) * k, (Ymax - Ymin) * k);

            // Инициализируем минимальное и максимальное значение цвета и коэффициент нормализации
            minColor = imageArray[Ymin, Xmin];
            maxColor = imageArray[Ymin, Xmin];
            coefficient = 1;

            // Находим минимальное и максимальное значения цвета для нормализации
            for (int y = Ymin + 1; y < Ymax; y++)
            {
                for (int x = Xmin + 1; x < Xmax; x++)
                {
                    if (imageArray[y, x] < minColor) minColor = imageArray[y, x];
                    if (imageArray[y, x] > maxColor) maxColor = imageArray[y, x];
                }
                coefficient =(double)((maxColor - minColor)/(255));
            }

            // Если активирована опция билинейной интерполяции и уровень увеличения не равен 1
            if (checkBoxInterpolate.Checked && k != 1)
                CreateBilinearZoomedBitmap();
            else
                CreateNearestNeighborZoomedBitmap();

            // Устанавливаем увеличенное изображение в элемент управления PictureBoxZoom и обновляем его
            pictureBoxZoom.Image = ZoomBitmap;
            pictureBoxZoom.Refresh();
        }

        // Билинейный метод
        private void CreateBilinearZoomedBitmap()
        {
            // Переменные для координат соседних пикселей и их яркостей
            ushort x2, y2;
            int I11, I12, I21, I22;
            double a, b, c, d;
            double step = 1 / (double)k;

            // Проходим по всем пикселям в исходном изображении
            for (short y1 = (short)Ymin; y1 < Ymax - 1; y1++)
            {
                for (short x1 = (short)Xmin; x1 < Xmax - 1; x1++)
                {
                    x2 = (ushort)(x1 + 1);
                    y2 = (ushort)(y1 + 1);

                    // Нормализуем яркость крайних пикселей, если опция активирована
                    if (checkBoxNormalize.Checked)
                    {
                        I11 = (int)((imageArray[y1, x1] - minColor) / coefficient);
                        I12 = (int)((imageArray[y1, x2] - minColor) / coefficient);
                        I21 = (int)((imageArray[y2, x1] - minColor) / coefficient);
                        I22 = (int)((imageArray[y2, x2] - minColor) / coefficient);
                    }
                    else
                    {
                        I11 = imageArray[y1, x1];
                        I12 = imageArray[y1, x2];
                        I21 = imageArray[y2, x1];
                        I22 = imageArray[y2, x2];
                    }

                    // Вычисляем значения для билинейной интерполяции
                    d = I11;
                    a = I12 - d;
                    b = I21 - d;
                    c = I22 - a - b - d;

                    // Вычисляем координаты пикселя в увеличенной области
                    int dx = (x1 - Xmin) * k + 1;
                    int dy = (y1 - Ymin) * k + 1;

                    // Заполняем увеличенное изображение соответствующими цветами
                    for (double x = 0; x <= 1; x += step)
                    {
                        for (double y = 0; y <= 1; y += step)
                        {
                            color = (byte)(a * x + b * y + c * x * y + d);
                            ZoomBitmap.SetPixel((int)(dx + (x * k)), (int)(dy + (y * k)), colorsArray[color]);
                        }
                    }
                }
            }
        }

        // Метод ближайшего соседа
        private void CreateNearestNeighborZoomedBitmap()
        {
            // Проходим по всем пикселям в исходном изображении
            for (int y = Ymin; y < Ymax; y++)
            {
                for (int x = Xmin; x < Xmax; x++)
                {
                    // Если опция нормализации активирована, сбрасываем сдвиг битов
                    if (checkBoxNormalize.Checked)
                    {
                        color = (byte)((imageArray[y, x] - minColor) * coefficient);
                    }
                    else
                    {
                        color = (byte)(imageArray[y, x] >> shift);
                    }

                    // Рассчитываем координаты пикселя в увеличенной области
                    short startX = (short)((x - Xmin) * k);
                    short startY = (short)((y - Ymin) * k);

                    // Устанавливаем цвет для всех пикселей в увеличенной области
                    for (short kx = startX; kx < startX + k; kx++)
                    {
                        for (short ky = startY; ky < startY + k; ky++)
                        {
                            ZoomBitmap.SetPixel(kx, ky, colorsArray[color]);
                        }
                    }
                }
            }
        }

        private void panelUp_MouseMove(object sender, MouseEventArgs e) => UpdateMouseMoveLabel(e);
        private void panelCentral_MouseMove(object sender, MouseEventArgs e) => UpdateMouseMoveLabel(e);
        private void panelDown_MouseMove(object sender, MouseEventArgs e) => UpdateMouseMoveLabel(e, panelCentral.Height);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void segment1_Change(object sender, EventArgs e)
        {
            segmentValues[1] = (byte)segment1.Value;
            segment1label.Text = segment1.Value.ToString();
            updateNonLinearColors(0);
            updateNonLinearColors(1);
            UpdateNonLinearBrightness();
        }

        private void segment2_Change(object sender, EventArgs e)
        {
            segmentValues[2] = (byte)segment2.Value;
            segment2label.Text = segment2.Value.ToString();
            updateNonLinearColors(1);
            updateNonLinearColors(2);
            UpdateNonLinearBrightness();
        }

        private void segment3_Change(object sender, EventArgs e)
        {
            segmentValues[3] = (byte)segment3.Value;
            segment3label.Text = segment3.Value.ToString();
            updateNonLinearColors(2);
            updateNonLinearColors(3);
            UpdateNonLinearBrightness();
        }

        private void segment4_Change(object sender, EventArgs e)
        {
            segmentValues[4] = (byte)segment4.Value;
            segment4label.Text = segment4.Value.ToString();
            updateNonLinearColors(3);
            updateNonLinearColors(4);
            UpdateNonLinearBrightness();
        }

        private void segment5_Change(object sender, EventArgs e)
        {
            segmentValues[5] = (byte)segment5.Value;
            segment5label.Text = segment5.Value.ToString();
            updateNonLinearColors(4);
            updateNonLinearColors(5);
            UpdateNonLinearBrightness();
        }

        private void segment6_Change(object sender, EventArgs e)
        {
            segmentValues[6] = (byte)segment6.Value;
            segment6label.Text = segment6.Value.ToString();
            updateNonLinearColors(5);
            updateNonLinearColors(6);
            UpdateNonLinearBrightness();
        }

        private void segment7_Change(object sender, EventArgs e)
        {
            segmentValues[7] = (byte)segment7.Value;
            segment7label.Text = segment7.Value.ToString();
            updateNonLinearColors(6);
            updateNonLinearColors(7);
            UpdateNonLinearBrightness();
        }

        private void segment8_Change(object sender, EventArgs e)
        {
            segmentValues[8] = (byte)segment8.Value;
            segment8label.Text = segment8.Value.ToString();
            updateNonLinearColors(7);
            UpdateNonLinearBrightness();
        }

        private void UpdateNonLinearBrightness()
        {

            if(displayBitmap != null)
            {
                Bitmap bitmap = new Bitmap(width, height);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {

                        byte pixelValue = newColors[(imageArray[y, x])];

                        bitmap.SetPixel(x, y, colorsArray[pixelValue]);
                    }
                }

                displayBitmap = bitmap;
                mainPicturebox.Image = displayBitmap;
                mainPicturebox.Size = new Size(width, height);
            }




            chart1.Series["Brightness"].Points.Clear();

            for (int i = 0; i < segmentGaps.Length; i++)
            {
                chart1.Series["Brightness"].Points.AddXY((int)segmentGaps[i], (int)segmentValues[i]);
            }
            
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            zoomPanel.Visible = true;
            brightnessNonLinearPanel.Visible = false;
            isZoom = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            zoomPanel.Visible = false;
            brightnessNonLinearPanel.Visible = true;
            isZoom = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void segment0_Scroll(object sender, EventArgs e)
        {
            segmentValues[0] = (byte)segment0.Value;
            segment0label.Text = segment0.Value.ToString();
            updateNonLinearColors(0);
            UpdateNonLinearBrightness();
        }

        private void labelColor_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}