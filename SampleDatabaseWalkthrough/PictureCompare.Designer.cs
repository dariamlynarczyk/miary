namespace SampleDatabaseWalkthrough
{
    partial class PictureCompare
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSquareDiffSum = new System.Windows.Forms.Button();
            this.btnMutualInformation = new System.Windows.Forms.Button();
            this.btnCrossCorrelation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPictureView1 = new System.Windows.Forms.Panel();
            this.pnlPictureView2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenFile1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenFile2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlPictureView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPictureView2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(873, 542);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.btnSquareDiffSum);
            this.panel1.Controls.Add(this.btnMutualInformation);
            this.panel1.Controls.Add(this.btnCrossCorrelation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 84);
            this.panel1.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResult.Location = new System.Drawing.Point(7, 51);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 26);
            this.lblResult.TabIndex = 4;
            // 
            // btnSquareDiffSum
            // 
            this.btnSquareDiffSum.Location = new System.Drawing.Point(413, 21);
            this.btnSquareDiffSum.Name = "btnSquareDiffSum";
            this.btnSquareDiffSum.Size = new System.Drawing.Size(197, 23);
            this.btnSquareDiffSum.TabIndex = 3;
            this.btnSquareDiffSum.Text = "Suma kwadratów różnic";
            this.btnSquareDiffSum.UseVisualStyleBackColor = true;
            this.btnSquareDiffSum.Click += new System.EventHandler(this.btnSquareDiffSum_Click);
            // 
            // btnMutualInformation
            // 
            this.btnMutualInformation.Location = new System.Drawing.Point(210, 21);
            this.btnMutualInformation.Name = "btnMutualInformation";
            this.btnMutualInformation.Size = new System.Drawing.Size(197, 23);
            this.btnMutualInformation.TabIndex = 2;
            this.btnMutualInformation.Text = "Mutual information";
            this.btnMutualInformation.UseVisualStyleBackColor = true;
            this.btnMutualInformation.Click += new System.EventHandler(this.btnMutualInformation_Click);
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
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miary podobieństwa";
            // 
            // pnlPictureView1
            // 
            this.pnlPictureView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPictureView1.Location = new System.Drawing.Point(3, 33);
            this.pnlPictureView1.Name = "pnlPictureView1";
            this.pnlPictureView1.Size = new System.Drawing.Size(430, 416);
            this.pnlPictureView1.TabIndex = 1;
            // 
            // pnlPictureView2
            // 
            this.pnlPictureView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPictureView2.Location = new System.Drawing.Point(439, 33);
            this.pnlPictureView2.Name = "pnlPictureView2";
            this.pnlPictureView2.Size = new System.Drawing.Size(431, 416);
            this.pnlPictureView2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnOpenFile1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(436, 30);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnOpenFile1
            // 
            this.btnOpenFile1.Location = new System.Drawing.Point(3, 3);
            this.btnOpenFile1.Name = "btnOpenFile1";
            this.btnOpenFile1.Size = new System.Drawing.Size(197, 23);
            this.btnOpenFile1.TabIndex = 4;
            this.btnOpenFile1.Text = "Z pliku";
            this.btnOpenFile1.UseVisualStyleBackColor = true;
            this.btnOpenFile1.Click += new System.EventHandler(this.btnOpenFile1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnOpenFile2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(436, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(437, 30);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // btnOpenFile2
            // 
            this.btnOpenFile2.Location = new System.Drawing.Point(3, 3);
            this.btnOpenFile2.Name = "btnOpenFile2";
            this.btnOpenFile2.Size = new System.Drawing.Size(197, 23);
            this.btnOpenFile2.TabIndex = 4;
            this.btnOpenFile2.Text = "Z pliku";
            this.btnOpenFile2.UseVisualStyleBackColor = true;
            this.btnOpenFile2.Click += new System.EventHandler(this.btnOpenFile2_Click);
            // 
            // PictureCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PictureCompare";
            this.Size = new System.Drawing.Size(873, 542);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrossCorrelation;
        private System.Windows.Forms.Button btnMutualInformation;
        private System.Windows.Forms.Button btnSquareDiffSum;
        private System.Windows.Forms.Panel pnlPictureView1;
        private System.Windows.Forms.Panel pnlPictureView2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOpenFile1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnOpenFile2;
    }
}
