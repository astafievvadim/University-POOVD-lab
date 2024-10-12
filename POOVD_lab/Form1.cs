using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

        // Конструктор класса Form1
        public Form1()
        {
            // Инициализация компонентов формы
            InitializeComponent();

            // Инициализация массива цветов
            colorsArray = Enumerable.Range(0, 256)
                                    .Select(i => Color.FromArgb(i, i, i))
                                    .ToArray();

            // Инициализация объекта Graphics для PictureBox
            g = pictureBox.CreateGraphics();
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
                // Чтение изображения из бинарного файла
                // Используем FileStream для более быстрого чтения
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    // Чтение ширины и высоты
                    width = reader.ReadUInt16();
                    height = reader.ReadUInt16();

                    // Создание двумерного массива для хранения пикселей
                    imageArray = new ushort[height, width];

                    // Чтение всех пикселей за один раз
                    byte[] pixelData = reader.ReadBytes(height * width * sizeof(ushort));

                    // Заполнение двумерного массива
                    for (int i = 0; i < pixelData.Length / sizeof(ushort); i++)
                    {
                        int y = i / width; // Определение индекса по высоте
                        int x = i % width; // Определение индекса по ширине
                        imageArray[y, x] = BitConverter.ToUInt16(pixelData, i * sizeof(ushort));
                    }
                }

                // Создание и отображение Bitmap изображения
                displayBitmap = CreateDisplayBitmap();
                pictureBox.Image = displayBitmap;
                pictureBox.Size = new Size(width, height);

                // Отображение информации о файле
                labelFilePath.Text = Path.GetFileName(filePath);
                labelSize.Text = $"Размер изображения: {width}x{height}";

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
                int pixelValue = Convert.ToInt32(textBoxPixel.Text);
                if (pixelValue >= 1 && pixelValue <= width)
                {
                    pictureBox.Location = new Point(pictureBox.Location.X, -pixelValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Введено неверное значение.\n Значение должно быть от 0 до 3000.");
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
                MessageBox.Show("Введено неверное значение.\nЗначение должно быть от 1 до width.\n");
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

        // Обработчик события перемещения мыши над PictureBox
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image != null)
            {
                labelCoordinate.Text = $"Координаты X: {e.X} Y: {e.Y}";
                labelColor.Text = $"Яркость: {imageArray[e.Y, e.X]}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

