namespace SampleDatabaseWalkthrough
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSquareDiff = new System.Windows.Forms.Button();
            this.btnMutualInfo = new System.Windows.Forms.Button();
            this.btnCrossCorrelation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPictureView1 = new System.Windows.Forms.Panel();
            this.panelPictureView2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelPictureView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelPictureView2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSquareDiff);
            this.panel1.Controls.Add(this.btnMutualInfo);
            this.panel1.Controls.Add(this.btnCrossCorrelation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 146);
            this.panel1.TabIndex = 0;
            // 
            // btnSquareDiff
            // 
            this.btnSquareDiff.Location = new System.Drawing.Point(417, 21);
            this.btnSquareDiff.Name = "btnSquareDiff";
            this.btnSquareDiff.Size = new System.Drawing.Size(200, 23);
            this.btnSquareDiff.TabIndex = 3;
            this.btnSquareDiff.Text = "Suma kwadratów różnic";
            this.btnSquareDiff.UseVisualStyleBackColor = true;
            this.btnSquareDiff.Click += new System.EventHandler(this.btnSquareDiff_Click);
            // 
            // btnMutualInfo
            // 
            this.btnMutualInfo.Location = new System.Drawing.Point(211, 21);
            this.btnMutualInfo.Name = "btnMutualInfo";
            this.btnMutualInfo.Size = new System.Drawing.Size(200, 23);
            this.btnMutualInfo.TabIndex = 2;
            this.btnMutualInfo.Text = "Mutual information";
            this.btnMutualInfo.UseVisualStyleBackColor = true;
            this.btnMutualInfo.Click += new System.EventHandler(this.btnMutualInfo_Click);
            // 
            // btnCrossCorrelation
            // 
            this.btnCrossCorrelation.Location = new System.Drawing.Point(7, 21);
            this.btnCrossCorrelation.Name = "btnCrossCorrelation";
            this.btnCrossCorrelation.Size = new System.Drawing.Size(197, 23);
            this.btnCrossCorrelation.TabIndex = 1;
            this.btnCrossCorrelation.Text = "Cross-correlation";
            this.btnCrossCorrelation.UseVisualStyleBackColor = true;
            this.btnCrossCorrelation.Click += new System.EventHandler(this.btnCrossCorrelation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miary korelacji";
            // 
            // panelPictureView1
            // 
            this.panelPictureView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPictureView1.Location = new System.Drawing.Point(3, 3);
            this.panelPictureView1.Name = "panelPictureView1";
            this.panelPictureView1.Size = new System.Drawing.Size(405, 348);
            this.panelPictureView1.TabIndex = 1;
            // 
            // panelPictureView2
            // 
            this.panelPictureView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPictureView2.Location = new System.Drawing.Point(414, 3);
            this.panelPictureView2.Name = "panelPictureView2";
            this.panelPictureView2.Size = new System.Drawing.Size(405, 348);
            this.panelPictureView2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pbResult);
            this.panel2.Location = new System.Drawing.Point(7, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 92);
            this.panel2.TabIndex = 4;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(4, 4);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(245, 139);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbResult.TabIndex = 0;
            this.pbResult.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Wpływ przekształceń obrazu na miary korelacji";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSquareDiff;
        private System.Windows.Forms.Button btnMutualInfo;
        private System.Windows.Forms.Button btnCrossCorrelation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPictureView1;
        private System.Windows.Forms.Panel panelPictureView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbResult;

       // public System.EventHandler button1_Click { get;}
    }
}

