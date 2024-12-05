using System;

namespace UsersGraphics
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelCoordinate = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.labelShift = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelColor = new System.Windows.Forms.Label();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.labelPixel = new System.Windows.Forms.Label();
            this.textBoxPixel = new System.Windows.Forms.TextBox();
            this.buttonPixel = new System.Windows.Forms.Button();
            this.scrollStepBox = new System.Windows.Forms.TextBox();
            this.labelScrollStep = new System.Windows.Forms.Label();
            this.buttonScrollStep = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.thumbnailPicturebox = new System.Windows.Forms.PictureBox();
            this.mainPicturebox = new System.Windows.Forms.PictureBox();
            this.zoomPanel = new System.Windows.Forms.Panel();
            this.brightnessNonLinearPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nonLinearBrightness = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.segment1 = new System.Windows.Forms.TrackBar();
            this.segment3 = new System.Windows.Forms.TrackBar();
            this.segment2 = new System.Windows.Forms.TrackBar();
            this.segment4 = new System.Windows.Forms.TrackBar();
            this.segment8 = new System.Windows.Forms.TrackBar();
            this.segment6 = new System.Windows.Forms.TrackBar();
            this.segment7 = new System.Windows.Forms.TrackBar();
            this.segment5 = new System.Windows.Forms.TrackBar();
            this.thumbnailCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBoxNormalize = new System.Windows.Forms.CheckBox();
            this.checkBoxInterpolate = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBoxZoom = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelCentral.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicturebox)).BeginInit();
            this.zoomPanel.SuspendLayout();
            this.brightnessNonLinearPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segment1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.AutoSize = true;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.Location = new System.Drawing.Point(3, 26);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(197, 26);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilePath.Location = new System.Drawing.Point(3, 9);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(42, 16);
            this.labelFilePath.TabIndex = 3;
            this.labelFilePath.Text = "Файл";
            this.labelFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vScrollBar.Location = new System.Drawing.Point(506, 0);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(20, 600);
            this.vScrollBar.TabIndex = 7;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(604, 5);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(69, 20);
            this.labelSize.TabIndex = 8;
            this.labelSize.Text = "Размер:";
            // 
            // labelCoordinate
            // 
            this.labelCoordinate.AutoSize = true;
            this.labelCoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordinate.Location = new System.Drawing.Point(771, 5);
            this.labelCoordinate.Name = "labelCoordinate";
            this.labelCoordinate.Size = new System.Drawing.Size(108, 20);
            this.labelCoordinate.TabIndex = 9;
            this.labelCoordinate.Text = "Координаты:";
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCentral.Controls.Add(this.brightnessNonLinearPanel);
            this.panelCentral.Controls.Add(this.panel3);
            this.panelCentral.Controls.Add(this.panel5);
            this.panelCentral.Controls.Add(this.panel2);
            this.panelCentral.Controls.Add(this.zoomPanel);
            this.panelCentral.Location = new System.Drawing.Point(0, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1140, 661);
            this.panelCentral.TabIndex = 10;
            this.panelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentral_Paint);
            this.panelCentral.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCentral_MouseMove);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(11, 39);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 20);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Яркость";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(11, 74);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 20);
            this.radioButton4.TabIndex = 25;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Лупа";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelFilePath);
            this.panel5.Controls.Add(this.buttonLoad);
            this.panel5.Controls.Add(this.radioButton2);
            this.panel5.Controls.Add(this.labelShift);
            this.panel5.Controls.Add(this.radioButton1);
            this.panel5.Controls.Add(this.labelColor);
            this.panel5.Controls.Add(this.radioButton0);
            this.panel5.Controls.Add(this.labelPixel);
            this.panel5.Controls.Add(this.textBoxPixel);
            this.panel5.Controls.Add(this.buttonPixel);
            this.panel5.Controls.Add(this.labelCoordinate);
            this.panel5.Controls.Add(this.scrollStepBox);
            this.panel5.Controls.Add(this.labelScrollStep);
            this.panel5.Controls.Add(this.buttonScrollStep);
            this.panel5.Controls.Add(this.labelSize);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1140, 55);
            this.panel5.TabIndex = 20;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(1097, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShift.Location = new System.Drawing.Point(993, 9);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(125, 16);
            this.labelShift.TabIndex = 17;
            this.labelShift.Text = "Сдвигать коды на:";
            this.labelShift.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(1045, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 20);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelColor.Location = new System.Drawing.Point(604, 27);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(77, 20);
            this.labelColor.TabIndex = 18;
            this.labelColor.Text = "Яркость:";
            this.labelColor.Click += new System.EventHandler(this.labelColor_Click);
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton0.Location = new System.Drawing.Point(996, 28);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(32, 20);
            this.radioButton0.TabIndex = 8;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = "0";
            this.radioButton0.UseVisualStyleBackColor = true;
            this.radioButton0.CheckedChanged += new System.EventHandler(this.radioButton0_CheckedChanged);
            // 
            // labelPixel
            // 
            this.labelPixel.AutoSize = true;
            this.labelPixel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPixel.Location = new System.Drawing.Point(209, 9);
            this.labelPixel.Name = "labelPixel";
            this.labelPixel.Size = new System.Drawing.Size(201, 16);
            this.labelPixel.TabIndex = 16;
            this.labelPixel.Text = "Верхние строки изображения";
            this.labelPixel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPixel
            // 
            this.textBoxPixel.Location = new System.Drawing.Point(212, 28);
            this.textBoxPixel.Name = "textBoxPixel";
            this.textBoxPixel.Size = new System.Drawing.Size(100, 20);
            this.textBoxPixel.TabIndex = 14;
            // 
            // buttonPixel
            // 
            this.buttonPixel.AutoSize = true;
            this.buttonPixel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPixel.Location = new System.Drawing.Point(346, 26);
            this.buttonPixel.Name = "buttonPixel";
            this.buttonPixel.Size = new System.Drawing.Size(64, 26);
            this.buttonPixel.TabIndex = 15;
            this.buttonPixel.Text = "Задать";
            this.buttonPixel.UseVisualStyleBackColor = true;
            this.buttonPixel.Click += new System.EventHandler(this.buttonPixel_Click);
            // 
            // scrollStepBox
            // 
            this.scrollStepBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scrollStepBox.Location = new System.Drawing.Point(422, 26);
            this.scrollStepBox.Name = "scrollStepBox";
            this.scrollStepBox.Size = new System.Drawing.Size(100, 22);
            this.scrollStepBox.TabIndex = 11;
            // 
            // labelScrollStep
            // 
            this.labelScrollStep.AutoSize = true;
            this.labelScrollStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScrollStep.Location = new System.Drawing.Point(419, 9);
            this.labelScrollStep.Name = "labelScrollStep";
            this.labelScrollStep.Size = new System.Drawing.Size(104, 16);
            this.labelScrollStep.TabIndex = 12;
            this.labelScrollStep.Text = "Шаг прокрутки";
            this.labelScrollStep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonScrollStep
            // 
            this.buttonScrollStep.AutoSize = true;
            this.buttonScrollStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonScrollStep.Location = new System.Drawing.Point(529, 24);
            this.buttonScrollStep.Name = "buttonScrollStep";
            this.buttonScrollStep.Size = new System.Drawing.Size(64, 26);
            this.buttonScrollStep.TabIndex = 13;
            this.buttonScrollStep.Text = "Задать";
            this.buttonScrollStep.UseVisualStyleBackColor = true;
            this.buttonScrollStep.Click += new System.EventHandler(this.buttonScrollStep_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.thumbnailPicturebox);
            this.panel2.Controls.Add(this.vScrollBar);
            this.panel2.Controls.Add(this.mainPicturebox);
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 600);
            this.panel2.TabIndex = 19;
            // 
            // thumbnailPicturebox
            // 
            this.thumbnailPicturebox.Location = new System.Drawing.Point(198, 0);
            this.thumbnailPicturebox.Name = "thumbnailPicturebox";
            this.thumbnailPicturebox.Size = new System.Drawing.Size(100, 600);
            this.thumbnailPicturebox.TabIndex = 8;
            this.thumbnailPicturebox.TabStop = false;
            // 
            // mainPicturebox
            // 
            this.mainPicturebox.Location = new System.Drawing.Point(0, 0);
            this.mainPicturebox.MinimumSize = new System.Drawing.Size(500, 743);
            this.mainPicturebox.Name = "mainPicturebox";
            this.mainPicturebox.Size = new System.Drawing.Size(500, 743);
            this.mainPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainPicturebox.TabIndex = 4;
            this.mainPicturebox.TabStop = false;
            this.mainPicturebox.Click += new System.EventHandler(this.pictureBox_Click);
            this.mainPicturebox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_drawRedSquare);
            this.mainPicturebox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.mainPicturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // zoomPanel
            // 
            this.zoomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomPanel.Controls.Add(this.thumbnailCheckBox);
            this.zoomPanel.Controls.Add(this.checkBoxNormalize);
            this.zoomPanel.Controls.Add(this.checkBoxInterpolate);
            this.zoomPanel.Controls.Add(this.trackBar1);
            this.zoomPanel.Controls.Add(this.pictureBoxZoom);
            this.zoomPanel.Controls.Add(this.label1);
            this.zoomPanel.Location = new System.Drawing.Point(526, 58);
            this.zoomPanel.Name = "zoomPanel";
            this.zoomPanel.Size = new System.Drawing.Size(502, 600);
            this.zoomPanel.TabIndex = 18;
            // 
            // brightnessNonLinearPanel
            // 
            this.brightnessNonLinearPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.brightnessNonLinearPanel.Controls.Add(this.chart1);
            this.brightnessNonLinearPanel.Controls.Add(this.button1);
            this.brightnessNonLinearPanel.Controls.Add(this.nonLinearBrightness);
            this.brightnessNonLinearPanel.Controls.Add(this.panel1);
            this.brightnessNonLinearPanel.Location = new System.Drawing.Point(523, 61);
            this.brightnessNonLinearPanel.Name = "brightnessNonLinearPanel";
            this.brightnessNonLinearPanel.Size = new System.Drawing.Size(502, 600);
            this.brightnessNonLinearPanel.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Обновить значения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nonLinearBrightness
            // 
            this.nonLinearBrightness.AutoSize = true;
            this.nonLinearBrightness.Location = new System.Drawing.Point(59, 273);
            this.nonLinearBrightness.Name = "nonLinearBrightness";
            this.nonLinearBrightness.Size = new System.Drawing.Size(251, 17);
            this.nonLinearBrightness.TabIndex = 34;
            this.nonLinearBrightness.Text = "Функциональное преобразование яркостей";
            this.nonLinearBrightness.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.segment1);
            this.panel1.Controls.Add(this.segment3);
            this.panel1.Controls.Add(this.segment2);
            this.panel1.Controls.Add(this.segment4);
            this.panel1.Controls.Add(this.segment8);
            this.panel1.Controls.Add(this.segment6);
            this.panel1.Controls.Add(this.segment7);
            this.panel1.Controls.Add(this.segment5);
            this.panel1.Location = new System.Drawing.Point(58, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 238);
            this.panel1.TabIndex = 33;
            // 
            // segment1
            // 
            this.segment1.Location = new System.Drawing.Point(3, 3);
            this.segment1.Maximum = 255;
            this.segment1.Name = "segment1";
            this.segment1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.segment1.Size = new System.Drawing.Size(45, 226);
            this.segment1.TabIndex = 25;
            this.segment1.ValueChanged += new System.EventHandler(this.segment1_Change);
            // 
            // segment3
            // 
            this.segment3.Location = new System.Drawing.Point(105, 3);
            this.segment3.Maximum = 255;
            this.segment3.Name = "segment3";
            this.segment3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.segment3.Size = new System.Drawing.Size(45, 226);
            this.segment3.TabIndex = 32;
            this.segment3.ValueChanged += new System.EventHandler(this.segment3_Change);
            // 
            // segment2
            // 
            this.segment2.Location = new System.Drawing.Point(54, 3);
            this.segment2.Maximum = 255;
            this.segment2.Name = "segment2";
            this.segment2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.segment2.Size = new System.Drawing.Size(45, 226);
            this.segment2.TabIndex = 26;
            this.segment2.ValueChanged += new System.EventHandler(this.segment2_Change);
            // 
            // segment4
            // 
            this.segment4.Location = new System.Drawing.Point(156, 3);
            this.segment4.Maximum = 255;
            this.segment4.Name = "segment4";
            this.segment4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.segment4.Size = new System.Drawing.Size(45, 226);
            this.segment4.TabIndex = 31;
            this.segment4.ValueChanged += new System.EventHandler(this.segment4_Change);
            // 
            // segment8
            // 
            this.segment8.Location = new System.Drawing.Point(360, 3);
            this.segment8.Maximum = 255;
            this.segment8.Name = "segment8";
            this.segment8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.segment8.Size = new System.Drawing.Size(45, 226);
            this.segment8.TabIndex = 27;
            this.segment8.ValueChanged += new System.EventHandler(this.segment8_Change);
            // 
            // segment6
            // 
            this.segment6.Location = new System.Drawing.Point(258, 3);
            this.segment6.Maximum = 255;
            this.segment6.Name = "segment6";
            this.segment6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.segment6.Size = new System.Drawing.Size(45, 226);
            this.segment6.TabIndex = 30;
            this.segment6.ValueChanged += new System.EventHandler(this.segment6_Change);
            // 
            // segment7
            // 
            this.segment7.Location = new System.Drawing.Point(309, 3);
            this.segment7.Maximum = 255;
            this.segment7.Name = "segment7";
            this.segment7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.segment7.Size = new System.Drawing.Size(45, 226);
            this.segment7.TabIndex = 28;
            this.segment7.ValueChanged += new System.EventHandler(this.segment7_Change);
            // 
            // segment5
            // 
            this.segment5.Location = new System.Drawing.Point(207, 3);
            this.segment5.Maximum = 255;
            this.segment5.Name = "segment5";
            this.segment5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.segment5.Size = new System.Drawing.Size(45, 226);
            this.segment5.TabIndex = 29;
            this.segment5.ValueChanged += new System.EventHandler(this.segment5_Change);
            // 
            // thumbnailCheckBox
            // 
            this.thumbnailCheckBox.AutoSize = true;
            this.thumbnailCheckBox.Location = new System.Drawing.Point(34, 571);
            this.thumbnailCheckBox.Name = "thumbnailCheckBox";
            this.thumbnailCheckBox.Size = new System.Drawing.Size(147, 17);
            this.thumbnailCheckBox.TabIndex = 24;
            this.thumbnailCheckBox.Text = "Обзорное изображение";
            this.thumbnailCheckBox.UseVisualStyleBackColor = true;
            this.thumbnailCheckBox.CheckedChanged += new System.EventHandler(this.thumbnailCheckBox_CheckedChanged);
            // 
            // checkBoxNormalize
            // 
            this.checkBoxNormalize.AutoSize = true;
            this.checkBoxNormalize.Location = new System.Drawing.Point(34, 494);
            this.checkBoxNormalize.Name = "checkBoxNormalize";
            this.checkBoxNormalize.Size = new System.Drawing.Size(139, 17);
            this.checkBoxNormalize.TabIndex = 22;
            this.checkBoxNormalize.Text = "Нормировать яркость";
            this.checkBoxNormalize.UseVisualStyleBackColor = true;
            this.checkBoxNormalize.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxInterpolate
            // 
            this.checkBoxInterpolate.AutoSize = true;
            this.checkBoxInterpolate.Location = new System.Drawing.Point(34, 517);
            this.checkBoxInterpolate.Name = "checkBoxInterpolate";
            this.checkBoxInterpolate.Size = new System.Drawing.Size(116, 17);
            this.checkBoxInterpolate.TabIndex = 23;
            this.checkBoxInterpolate.Text = "Интерполировать";
            this.checkBoxInterpolate.UseVisualStyleBackColor = true;
            this.checkBoxInterpolate.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(34, 419);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(350, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pictureBoxZoom
            // 
            this.pictureBoxZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxZoom.Location = new System.Drawing.Point(34, 46);
            this.pictureBoxZoom.Name = "pictureBoxZoom";
            this.pictureBoxZoom.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxZoom.TabIndex = 19;
            this.pictureBoxZoom.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Приближенное изображение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BorderWidth = 5;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(59, 303);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Brightness";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(416, 262);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Режим";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Location = new System.Drawing.Point(1034, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 109);
            this.panel3.TabIndex = 27;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1141, 658);
            this.Controls.Add(this.panelCentral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCentral.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicturebox)).EndInit();
            this.zoomPanel.ResumeLayout(false);
            this.zoomPanel.PerformLayout();
            this.brightnessNonLinearPanel.ResumeLayout(false);
            this.brightnessNonLinearPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segment1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segment5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelCoordinate;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox scrollStepBox;
        private System.Windows.Forms.Button buttonScrollStep;
        private System.Windows.Forms.TextBox textBoxPixel;
        private System.Windows.Forms.Label labelPixel;
        private System.Windows.Forms.Button buttonPixel;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.Label labelScrollStep;
        private System.Windows.Forms.Panel zoomPanel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxZoom;
        private System.Windows.Forms.CheckBox checkBoxInterpolate;
        private System.Windows.Forms.CheckBox checkBoxNormalize;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox mainPicturebox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox thumbnailCheckBox;
        private System.Windows.Forms.PictureBox thumbnailPicturebox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel brightnessNonLinearPanel;
        private System.Windows.Forms.TrackBar segment1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar segment3;
        private System.Windows.Forms.TrackBar segment2;
        private System.Windows.Forms.TrackBar segment4;
        private System.Windows.Forms.TrackBar segment8;
        private System.Windows.Forms.TrackBar segment6;
        private System.Windows.Forms.TrackBar segment7;
        private System.Windows.Forms.TrackBar segment5;
        private System.Windows.Forms.CheckBox nonLinearBrightness;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}

