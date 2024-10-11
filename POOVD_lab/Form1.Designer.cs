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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelCoordinate = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelShift = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.scrollStepBox = new System.Windows.Forms.TextBox();
            this.labelPixel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonPixel = new System.Windows.Forms.Button();
            this.labelScrollStep = new System.Windows.Forms.Label();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.textBoxPixel = new System.Windows.Forms.TextBox();
            this.buttonScrollStep = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelCentral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.AutoSize = true;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.Location = new System.Drawing.Point(22, 56);
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
            this.labelFilePath.Location = new System.Drawing.Point(19, 26);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(42, 16);
            this.labelFilePath.TabIndex = 3;
            this.labelFilePath.Text = "Файл";
            this.labelFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.MinimumSize = new System.Drawing.Size(500, 768);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 768);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // vScrollBar
            // 
            this.vScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vScrollBar.Location = new System.Drawing.Point(500, 0);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(20, 768);
            this.vScrollBar.TabIndex = 7;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(18, 265);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(169, 20);
            this.labelSize.TabIndex = 8;
            this.labelSize.Text = "Размер изображения";
            // 
            // labelCoordinate
            // 
            this.labelCoordinate.AutoSize = true;
            this.labelCoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordinate.Location = new System.Drawing.Point(18, 306);
            this.labelCoordinate.Name = "labelCoordinate";
            this.labelCoordinate.Size = new System.Drawing.Size(171, 20);
            this.labelCoordinate.TabIndex = 9;
            this.labelCoordinate.Text = "Координаты курсора:";
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCentral.Controls.Add(this.panel1);
            this.panelCentral.Controls.Add(this.panel2);
            this.panelCentral.Location = new System.Drawing.Point(0, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(840, 771);
            this.panelCentral.TabIndex = 10;
            this.panelCentral.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCentral_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelColor);
            this.panel1.Controls.Add(this.labelShift);
            this.panel1.Controls.Add(this.labelFilePath);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.scrollStepBox);
            this.panel1.Controls.Add(this.labelPixel);
            this.panel1.Controls.Add(this.labelCoordinate);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.buttonPixel);
            this.panel1.Controls.Add(this.labelScrollStep);
            this.panel1.Controls.Add(this.radioButton0);
            this.panel1.Controls.Add(this.textBoxPixel);
            this.panel1.Controls.Add(this.labelSize);
            this.panel1.Controls.Add(this.buttonScrollStep);
            this.panel1.Location = new System.Drawing.Point(520, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 768);
            this.panel1.TabIndex = 18;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelColor.Location = new System.Drawing.Point(19, 345);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(73, 20);
            this.labelColor.TabIndex = 18;
            this.labelColor.Text = "Яркость";
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShift.Location = new System.Drawing.Point(19, 389);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(125, 16);
            this.labelShift.TabIndex = 17;
            this.labelShift.Text = "Сдвигать коды на:";
            this.labelShift.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(98, 417);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // scrollStepBox
            // 
            this.scrollStepBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scrollStepBox.Location = new System.Drawing.Point(21, 200);
            this.scrollStepBox.Name = "scrollStepBox";
            this.scrollStepBox.Size = new System.Drawing.Size(100, 22);
            this.scrollStepBox.TabIndex = 11;
            // 
            // labelPixel
            // 
            this.labelPixel.AutoSize = true;
            this.labelPixel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPixel.Location = new System.Drawing.Point(18, 99);
            this.labelPixel.Name = "labelPixel";
            this.labelPixel.Size = new System.Drawing.Size(201, 16);
            this.labelPixel.TabIndex = 16;
            this.labelPixel.Text = "Верхние строки изображения";
            this.labelPixel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(60, 417);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 20);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonPixel
            // 
            this.buttonPixel.AutoSize = true;
            this.buttonPixel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPixel.Location = new System.Drawing.Point(155, 130);
            this.buttonPixel.Name = "buttonPixel";
            this.buttonPixel.Size = new System.Drawing.Size(64, 26);
            this.buttonPixel.TabIndex = 15;
            this.buttonPixel.Text = "Задать";
            this.buttonPixel.UseVisualStyleBackColor = true;
            this.buttonPixel.Click += new System.EventHandler(this.buttonPixel_Click);
            // 
            // labelScrollStep
            // 
            this.labelScrollStep.AutoSize = true;
            this.labelScrollStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScrollStep.Location = new System.Drawing.Point(19, 172);
            this.labelScrollStep.Name = "labelScrollStep";
            this.labelScrollStep.Size = new System.Drawing.Size(104, 16);
            this.labelScrollStep.TabIndex = 12;
            this.labelScrollStep.Text = "Шаг прокрутки";
            this.labelScrollStep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton0.Location = new System.Drawing.Point(22, 417);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(32, 20);
            this.radioButton0.TabIndex = 8;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = "0";
            this.radioButton0.UseVisualStyleBackColor = true;
            this.radioButton0.CheckedChanged += new System.EventHandler(this.radioButton0_CheckedChanged);
            // 
            // textBoxPixel
            // 
            this.textBoxPixel.Location = new System.Drawing.Point(21, 130);
            this.textBoxPixel.Name = "textBoxPixel";
            this.textBoxPixel.Size = new System.Drawing.Size(100, 20);
            this.textBoxPixel.TabIndex = 14;
            // 
            // buttonScrollStep
            // 
            this.buttonScrollStep.AutoSize = true;
            this.buttonScrollStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonScrollStep.Location = new System.Drawing.Point(155, 196);
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
            this.panel2.Controls.Add(this.vScrollBar);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 768);
            this.panel2.TabIndex = 19;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(841, 768);
            this.Controls.Add(this.panelCentral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.PictureBox pictureBox;
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
        private System.Windows.Forms.Panel panel2;
    }
}

