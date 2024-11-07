using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private Bitmap displayBitmap;    // Изображение для отображения
        private Graphics g;             // Объект для рисования на PictureBox
        private int bufferSize = 8192; //Размер буфера для чтения изображения
        private Bitmap ZoomBitmap;
        private Bitmap bitmap_mini;
        private Graphics graphics_mini;
        private byte color;

        private Pen pen = new Pen(Color.Red, 2);

        //private double k_to_mini;
        private int Xmin, Ymin, Xmax, Ymax, minColor, maxColor, k; // переменные для интерполяции

        private double coefficient;

        // Конструктор класса Form1
        public Form1()
        {
            // Инициализация компонентов формы
            InitializeComponent();

            // Инициализация массива цветов
            colorsArray = Enumerable.Range(0, 256)
                                    .Select(i => Color.FromArgb(i, i, i))
                                    .ToArray();
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 4;
            pictureBoxMini.Visible = false;

            // Инициализация объекта Graphics для PictureBox
            g = pictureBox.CreateGraphics();
            graphics_mini = pictureBoxMini.CreateGraphics();
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
                pictureBox.Image = displayBitmap;
                pictureBox.Size = new Size(width, height);

                // Отображение информации о файле
                labelFilePath.Text = Path.GetFileName(filePath);
                labelSize.Text = $"Размер: {width}x{height}";

                // Инициализация сдвига кода
                shift = 0;
                radioButton0.Checked = true;

                // Настройка прокрутки
                vScrollBar.Maximum = pictureBox.Image.Height - panelCentral.Height / 2 + vScrollBar.LargeChange;
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

        void generateBitmapMini()
        {
            double scaleFactor = width / (double)pictureBoxMini.Width;
            int thumbnailWidth = pictureBoxMini.Width;
            int thumbnailHeight = (int)(height / scaleFactor);

            if (thumbnailHeight < 600)
            {
                pictureBoxMini.Height = thumbnailHeight;
            }
            else if (thumbnailHeight > 600)
            {
                MessageBox.Show("Не получилось создать обзорное изображение");
                return;
            }

            Bitmap thumbnailBitmap = new Bitmap(thumbnailWidth, thumbnailHeight);

            int minBrightness = 255;
            int maxBrightness = 0;
            int[][] brightnessValues;
            brightnessValues = new int[thumbnailHeight][];

            for (int y = 0; y < thumbnailHeight; y++)
            {
                brightnessValues[y] = new int[thumbnailWidth];
                for (int x = 0; x < thumbnailWidth; x++)
                {
                    int pixelSum = 0;
                    int xMax = (int)(x * scaleFactor + scaleFactor);
                    int yMax = (int)(y * scaleFactor + scaleFactor);

                    for (int pixelX = (int)(x * scaleFactor); pixelX < xMax; pixelX++)
                    {
                        for (int pixelY = (int)(y * scaleFactor); pixelY < yMax; pixelY++)
                        {
                            pixelSum += imageArray[pixelY, pixelX];
                        }
                    }

                    brightnessValues[y][x] = (int)(pixelSum / (scaleFactor * scaleFactor));
                    if (brightnessValues[y][x] < minBrightness) minBrightness = brightnessValues[y][x];
                    if (brightnessValues[y][x] > maxBrightness) maxBrightness = brightnessValues[y][x];
                }
            }

            double brightnessScale = (maxBrightness - minBrightness) / 255.0;

            byte adjustedColor;
            for (int x = 0; x < thumbnailWidth; x++)
            {
                for (int y = 0; y < thumbnailHeight; y++)
                {
                    adjustedColor = (byte)((brightnessValues[y][x] - minBrightness) / brightnessScale);
                    thumbnailBitmap.SetPixel(x, y, colorsArray[adjustedColor]);
                }
            }

            pictureBoxMini.Image = thumbnailBitmap;
        }


        private void drawMiniPosition()
        {

            pictureBoxMini.Refresh();
            graphics_mini.DrawLine(pen, 0, 0,
            pictureBoxMini.Width, 0);
            graphics_mini.DrawLine(pen, 0, height,
                pictureBoxMini.Width, height);
        }

        // создание bitmap для pictureBox
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
            pictureBox.Location = new Point(pictureBox.Location.X, newY);
            textBoxPixel.Text = $"{-pictureBox.Location.Y}";


        }

        // Обработчики событий MouseMove для панелей
        private void UpdateMouseMoveLabel(MouseEventArgs e, int yOffset = 0)
        {
            labelCoordinate.Text = $"Координаты X: {e.X} Y: {e.Y + yOffset}";
            labelColor.Text = "Яркость: наведите курсор на изображение";
        }

        private void panelUp_MouseMove(object sender, MouseEventArgs e) => UpdateMouseMoveLabel(e);
        private void panelCentral_MouseMove(object sender, MouseEventArgs e) => UpdateMouseMoveLabel(e);
        private void panelDown_MouseMove(object sender, MouseEventArgs e) => UpdateMouseMoveLabel(e, panelCentral.Height);

        // Обработчики событий изменения сдвига кода цвета
        private void UpdateShiftAndImage(int newShift)
        {
            shift = newShift;
            if (imageArray != null)
            {
                pictureBox.Image = CreateDisplayBitmap();
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
                    pictureBox.Location = new Point(pictureBox.Location.X, -Convert.ToInt32(textBoxPixel.Text));
                vScrollBar.Value = Math.Max(Convert.ToInt32(textBoxPixel.Text), vScrollBar.Minimum);
            }
            catch
            {
                MessageBox.Show(" Введено неверное значение.\n Значение должно быть от 0 до " + (height - vScrollBar.ClientSize.Height) + ". ");
                pictureBox.Location = new Point(pictureBox.Location.X, 0);
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
                    vScrollBar.Maximum = pictureBox.Image.Height - panelCentral.Height / 2 + 10 + stepValue;
                    vScrollBar.SmallChange = stepValue;
                    vScrollBar.LargeChange = stepValue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введено неверное значение.\nЗначение должно быть от 1 до " + width + ".");
                if (pictureBox.Image.Height == null)
                {
                    return;
                }
                vScrollBar.Maximum = pictureBox.Image.Height - panelCentral.Height / 2 + 10;
                vScrollBar.SmallChange = 1;
                vScrollBar.LargeChange = 1;
                scrollStepBox.Text = "1";

            }
        }

        // Обработчик события изменения значения trackBar
        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }

        // Обработчик события покидания мыши PictureBox
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        // Обработчик события перемещения мыши над PictureBox
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image != null)
            {
                labelCoordinate.Text = $"Координаты X: {e.X} Y: {e.Y}";
                labelColor.Text = $"Яркость: {imageArray[e.Y, e.X]}";

                g = pictureBox.CreateGraphics();
                CreateZoomedBitmap(e.X, e.Y);
                pictureBox.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelColor_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxMini_CheckedChanged(object sender, EventArgs e)
        {
            if (displayBitmap != null)
            {
                if (checkBoxMini.Checked)
                {
                    pictureBox.Visible = false;
                    vScrollBar.Visible = false;
                    // Отображение миниатюры
                    pictureBoxMini.Visible = true;
                    int newWidth = width / 4;
                    int newHeight = height / 4;
                    ushort[,] overviewImage = new ushort[newWidth, newHeight];

                    for (int y = 0; y < newHeight; y++)
                        for (int x = 0; x < newWidth; x++)
                        {
                            for (int y1 = 0; y1 < 4; y1++)
                                for (int x1 = 0; x1 < 4; x1++)
                                    overviewImage[x, y] += imageArray[y * 4 + y1, x * 4 + x1];

                            overviewImage[x, y] /= 16;
                        }
                    pictureBoxMini.Width = newWidth;
                    pictureBoxMini.Image = CreateMinBitmap(overviewImage, newHeight, newWidth);
                }
                else
                {
                    // Скрытие миниатюры
                    pictureBoxMini.Visible = false;
                    pictureBox.Visible = true;
                    vScrollBar.Visible = true;
                }
            }
            else MessageBox.Show("Загрузите изображение");
        }

        private Bitmap CreateMinBitmap(ushort[,] miniImage, int Height, int Width)
        {
            int xMin = pictureBoxMini.Width - Width / 2;
            Bitmap bitmap = new Bitmap(Width, Height);
            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                {
                    byte pixelValue = (byte)(miniImage[x, y]);
                    bitmap.SetPixel(x, y, colorsArray[pixelValue]);
                }

            return bitmap;
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

        private void CreateZoomedBitmap(int LocationX, int LocationY)
        {
            // Получаем уровень увеличения из значения ползунка
            k = trackBar1.Value * 2 + 1;

            // Рассчитываем расстояние до границы увеличенной области
            int dX = pictureBoxZoom.Width / (k) / 2;

            // Вычисляем граничные координаты ограничивающего прямоугольника
            Xmin = LocationX - dX; Ymin = LocationY - dX;
            Xmax = LocationX + dX; Ymax = LocationY + dX;

            // Проверяем и корректируем координаты, чтобы остаться внутри изображения
            if (Xmin < 0) { Xmax -= Xmin; Xmin = 0; }
            if (Ymin < 0) { Ymax -= Ymin; Ymin = 0; }
            if (Xmax >= width) { Xmin -= Xmax - width; Xmax = width; }
            if (Ymax >= height) { Ymin -= Ymax - height; Ymax = height; }

            // Создаем новое изображение (Bitmap) для увеличенной области
            ZoomBitmap = new Bitmap((Xmax - Xmin + 1) * k, (Ymax - Ymin + 1) * k);

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
                coefficient = (255 / (double)(maxColor - minColor));
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
            int x2, y2, I11, I12, I21, I22;
            double a, b, c, d;
            double step = 1 / (double)k;

            // Проходим по всем пикселям в исходном изображении
            for (int y1 = Ymin; y1 < Ymax - 1; y1++)
            {
                for (int x1 = Xmin; x1 < Xmax - 1; x1++)
                {
                    x2 = x1 + 1;
                    y2 = y1 + 1;

                    // Нормализуем яркость крайних пикселей, если опция активирована
                    if (checkBoxNormalize.Checked)
                    {
                        I11 = (int)((imageArray[y1, x1] - minColor) * coefficient);
                        I12 = (int)((imageArray[y1, x2] - minColor) * coefficient);
                        I21 = (int)((imageArray[y2, x1] - minColor) * coefficient);
                        I22 = (int)((imageArray[y2, x2] - minColor) * coefficient);
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
                    int startX = (x - Xmin) * k;
                    int startY = (y - Ymin) * k;

                    // Устанавливаем цвет для всех пикселей в увеличенной области
                    for (int kx = startX; kx < startX + k; kx++)
                    {
                        for (int ky = startY; ky < startY + k; ky++)
                        {
                            ZoomBitmap.SetPixel(kx, ky, colorsArray[color]);
                        }
                    }
                }
            }
        }

        private void pictureBox_drawRedSquare(object sender, PaintEventArgs e)
        {
                // Рисуем прямоугольник с использованием объекта Graphics из события Paint
                e.Graphics.DrawRectangle(pen, Xmin, Ymin, Xmax - Xmin, Ymax - Ymin);
            
        }
    }
}