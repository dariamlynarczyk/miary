namespace SampleDatabaseWalkthrough
{
    partial class PictureView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.btnRotate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnScale = new System.Windows.Forms.Button();
            this.cmbScale = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCropTop = new System.Windows.Forms.NumericUpDown();
            this.nudCropBottom = new System.Windows.Forms.NumericUpDown();
            this.nudCropRight = new System.Windows.Forms.NumericUpDown();
            this.nudCropLeft = new System.Windows.Forms.NumericUpDown();
            this.btnCrop = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNoise = new System.Windows.Forms.Button();
            this.btnDenoise = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudWindowSize = new System.Windows.Forms.NumericUpDown();
            this.nudNoiseIntens = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropLeft)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoiseIntens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Przekształcenia";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 315);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 166);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudAngle);
            this.panel1.Controls.Add(this.btnRotate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 160);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kąt obrotu";
            // 
            // nudAngle
            // 
            this.nudAngle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAngle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAngle.Location = new System.Drawing.Point(4, 27);
            this.nudAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(184, 20);
            this.nudAngle.TabIndex = 1;
            // 
            // btnRotate
            // 
            this.btnRotate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRotate.Location = new System.Drawing.Point(3, 53);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(185, 23);
            this.btnRotate.TabIndex = 0;
            this.btnRotate.Text = "Obróć";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnScale);
            this.panel3.Controls.Add(this.cmbScale);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 160);
            this.panel3.TabIndex = 5;
            // 
            // btnScale
            // 
            this.btnScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScale.Location = new System.Drawing.Point(6, 53);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(182, 23);
            this.btnScale.TabIndex = 2;
            this.btnScale.Text = "Skaluj";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // cmbScale
            // 
            this.cmbScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScale.FormattingEnabled = true;
            this.cmbScale.Location = new System.Drawing.Point(6, 26);
            this.cmbScale.Name = "cmbScale";
            this.cmbScale.Size = new System.Drawing.Size(182, 21);
            this.cmbScale.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Skala";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.nudCropTop, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudCropBottom, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudCropRight, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.nudCropLeft, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnCrop, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(397, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(191, 160);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Góra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dół";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Prawo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lewo";
            // 
            // nudCropTop
            // 
            this.nudCropTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudCropTop.Location = new System.Drawing.Point(3, 23);
            this.nudCropTop.Name = "nudCropTop";
            this.nudCropTop.Size = new System.Drawing.Size(89, 20);
            this.nudCropTop.TabIndex = 4;
            // 
            // nudCropBottom
            // 
            this.nudCropBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudCropBottom.Location = new System.Drawing.Point(98, 23);
            this.nudCropBottom.Name = "nudCropBottom";
            this.nudCropBottom.Size = new System.Drawing.Size(90, 20);
            this.nudCropBottom.TabIndex = 5;
            // 
            // nudCropRight
            // 
            this.nudCropRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudCropRight.Location = new System.Drawing.Point(3, 73);
            this.nudCropRight.Name = "nudCropRight";
            this.nudCropRight.Size = new System.Drawing.Size(89, 20);
            this.nudCropRight.TabIndex = 6;
            // 
            // nudCropLeft
            // 
            this.nudCropLeft.Location = new System.Drawing.Point(98, 73);
            this.nudCropLeft.Name = "nudCropLeft";
            this.nudCropLeft.Size = new System.Drawing.Size(90, 20);
            this.nudCropLeft.TabIndex = 7;
            // 
            // btnCrop
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnCrop, 2);
            this.btnCrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrop.Location = new System.Drawing.Point(3, 103);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(185, 23);
            this.btnCrop.TabIndex = 8;
            this.btnCrop.Text = "Przytnij";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.nudNoiseIntens);
            this.panel4.Controls.Add(this.nudWindowSize);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnNoise);
            this.panel4.Controls.Add(this.btnDenoise);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(594, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 160);
            this.panel4.TabIndex = 7;
            // 
            // btnNoise
            // 
            this.btnNoise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoise.Location = new System.Drawing.Point(3, 124);
            this.btnNoise.Name = "btnNoise";
            this.btnNoise.Size = new System.Drawing.Size(185, 23);
            this.btnNoise.TabIndex = 4;
            this.btnNoise.Text = "Dodaj szum";
            this.btnNoise.UseVisualStyleBackColor = true;
            this.btnNoise.Click += new System.EventHandler(this.btnNoise_Click);
            // 
            // btnDenoise
            // 
            this.btnDenoise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDenoise.Location = new System.Drawing.Point(6, 47);
            this.btnDenoise.Name = "btnDenoise";
            this.btnDenoise.Size = new System.Drawing.Size(185, 23);
            this.btnDenoise.TabIndex = 3;
            this.btnDenoise.Text = "Odszumianie";
            this.btnDenoise.UseVisualStyleBackColor = true;
            this.btnDenoise.Click += new System.EventHandler(this.btnDenoise_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 293);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Wielkość okna";
            // 
            // nudWindowSize
            // 
            this.nudWindowSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWindowSize.Location = new System.Drawing.Point(6, 21);
            this.nudWindowSize.Name = "nudWindowSize";
            this.nudWindowSize.Size = new System.Drawing.Size(182, 20);
            this.nudWindowSize.TabIndex = 6;
            // 
            // nudNoiseIntens
            // 
            this.nudNoiseIntens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNoiseIntens.Location = new System.Drawing.Point(6, 98);
            this.nudNoiseIntens.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoiseIntens.Name = "nudNoiseIntens";
            this.nudNoiseIntens.Size = new System.Drawing.Size(182, 20);
            this.nudNoiseIntens.TabIndex = 7;
            this.nudNoiseIntens.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Intensywność szumu";
            // 
            // PictureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "PictureView";
            this.Size = new System.Drawing.Size(798, 482);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropLeft)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoiseIntens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDenoise;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCropTop;
        private System.Windows.Forms.NumericUpDown nudCropBottom;
        private System.Windows.Forms.NumericUpDown nudCropRight;
        private System.Windows.Forms.NumericUpDown nudCropLeft;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNoise;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudNoiseIntens;
        private System.Windows.Forms.NumericUpDown nudWindowSize;
    }
}
