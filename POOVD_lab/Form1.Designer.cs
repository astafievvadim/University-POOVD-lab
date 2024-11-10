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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelCoordinate = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
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
            this.pictureBoxMini = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxMiniature = new System.Windows.Forms.CheckBox();
            this.checkBoxNormalize = new System.Windows.Forms.CheckBox();
            this.checkBoxInterpolate = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBoxZoom = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCentral.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).BeginInit();
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
            this.vScrollBar.Size = new System.Drawing.Size(20, 743);
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
            this.panelCentral.Controls.Add(this.panel5);
            this.panelCentral.Controls.Add(this.panel2);
            this.panelCentral.Controls.Add(this.panel1);
            this.panelCentral.Location = new System.Drawing.Point(0, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1140, 804);
            this.panelCentral.TabIndex = 10;
            this.panelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentral_Paint);
            this.panelCentral.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCentral_MouseMove);
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
            this.panel2.Controls.Add(this.pictureBoxMini);
            this.panel2.Controls.Add(this.vScrollBar);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 743);
            this.panel2.TabIndex = 19;
            // 
            // pictureBoxMini
            // 
            this.pictureBoxMini.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxMini.Location = new System.Drawing.Point(140, 0);
            this.pictureBoxMini.Name = "pictureBoxMini";
            this.pictureBoxMini.Size = new System.Drawing.Size(100, 600);
            this.pictureBoxMini.TabIndex = 8;
            this.pictureBoxMini.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.MinimumSize = new System.Drawing.Size(500, 743);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 743);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_drawRedSquare);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.checkBoxMiniature);
            this.panel1.Controls.Add(this.checkBoxNormalize);
            this.panel1.Controls.Add(this.checkBoxInterpolate);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.pictureBoxZoom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(526, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 743);
            this.panel1.TabIndex = 18;
            // 
            // checkBoxMiniature
            // 
            this.checkBoxMiniature.AutoSize = true;
            this.checkBoxMiniature.Location = new System.Drawing.Point(445, 494);
            this.checkBoxMiniature.Name = "checkBoxMiniature";
            this.checkBoxMiniature.Size = new System.Drawing.Size(147, 17);
            this.checkBoxMiniature.TabIndex = 24;
            this.checkBoxMiniature.Text = "Обзорное изображение";
            this.checkBoxMiniature.UseVisualStyleBackColor = true;
            this.checkBoxMiniature.CheckedChanged += new System.EventHandler(this.checkBoxMini_CheckedChanged);
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
            this.trackBar1.Size = new System.Drawing.Size(558, 45);
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1141, 801);
            this.Controls.Add(this.panelCentral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCentral.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxZoom;
        private System.Windows.Forms.CheckBox checkBoxInterpolate;
        private System.Windows.Forms.CheckBox checkBoxNormalize;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox checkBoxMiniature;
        private System.Windows.Forms.PictureBox pictureBoxMini;
    }
}

