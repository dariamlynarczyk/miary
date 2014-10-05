namespace SampleDatabaseWalkthrough
{
    partial class PatientList
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGivenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGivenName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFamilyName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.colNoteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoteContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnEditNote = new System.Windows.Forms.Button();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.btnEditPhoto = new System.Windows.Forms.Button();
            this.btnDeletePhoto = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPhoto = new System.Windows.Forms.DataGridView();
            this.colPhotoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhotoSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imgPreview = new Emgu.CV.UI.ImageBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoto)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 434);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPatients);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(294, 428);
            this.panel1.TabIndex = 2;
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFamilyName,
            this.colGivenName});
            this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatients.Location = new System.Drawing.Point(0, 33);
            this.dgvPatients.MultiSelect = false;
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(294, 395);
            this.dgvPatients.TabIndex = 1;
            this.dgvPatients.SelectionChanged += new System.EventHandler(this.dgvPatients_SelectionChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "#";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 40;
            // 
            // colFamilyName
            // 
            this.colFamilyName.DataPropertyName = "FamilyName";
            this.colFamilyName.HeaderText = "Nazwisko";
            this.colFamilyName.Name = "colFamilyName";
            this.colFamilyName.ReadOnly = true;
            // 
            // colGivenName
            // 
            this.colGivenName.DataPropertyName = "GivenName";
            this.colGivenName.HeaderText = "Imię";
            this.colGivenName.Name = "colGivenName";
            this.colGivenName.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddPatient);
            this.flowLayoutPanel1.Controls.Add(this.btnEditPatient);
            this.flowLayoutPanel1.Controls.Add(this.btnDeletePatient);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(294, 33);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(3, 3);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(75, 23);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Dodaj";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Enabled = false;
            this.btnEditPatient.Location = new System.Drawing.Point(84, 3);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(75, 23);
            this.btnEditPatient.TabIndex = 1;
            this.btnEditPatient.Text = "Edytuj";
            this.btnEditPatient.UseVisualStyleBackColor = true;
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Enabled = false;
            this.btnDeletePatient.Location = new System.Drawing.Point(165, 3);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePatient.TabIndex = 2;
            this.btnDeletePatient.Text = "Usuń";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBirthDate);
            this.panel2.Controls.Add(this.lblGivenName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblFamilyName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(303, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 74);
            this.panel2.TabIndex = 3;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(116, 46);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(0, 13);
            this.lblBirthDate.TabIndex = 5;
            // 
            // lblGivenName
            // 
            this.lblGivenName.AutoSize = true;
            this.lblGivenName.Location = new System.Drawing.Point(113, 23);
            this.lblGivenName.Name = "lblGivenName";
            this.lblGivenName.Size = new System.Drawing.Size(0, 13);
            this.lblGivenName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data urodzenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(66, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imię";
            // 
            // lblFamilyName
            // 
            this.lblFamilyName.AutoSize = true;
            this.lblFamilyName.Location = new System.Drawing.Point(113, 3);
            this.lblFamilyName.Name = "lblFamilyName";
            this.lblFamilyName.Size = new System.Drawing.Size(0, 13);
            this.lblFamilyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwisko";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(303, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 348);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvNotes);
            this.tabPage1.Controls.Add(this.flowLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Notatki";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.AllowUserToDeleteRows = false;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNoteId,
            this.colNoteContent});
            this.dgvNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotes.Location = new System.Drawing.Point(3, 36);
            this.dgvNotes.MultiSelect = false;
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(536, 283);
            this.dgvNotes.TabIndex = 1;
            this.dgvNotes.SelectionChanged += new System.EventHandler(this.dgvNotes_SelectionChanged);
            // 
            // colNoteId
            // 
            this.colNoteId.DataPropertyName = "Id";
            this.colNoteId.FillWeight = 40F;
            this.colNoteId.HeaderText = "#";
            this.colNoteId.Name = "colNoteId";
            this.colNoteId.ReadOnly = true;
            this.colNoteId.Width = 40;
            // 
            // colNoteContent
            // 
            this.colNoteContent.DataPropertyName = "Content";
            this.colNoteContent.FillWeight = 200F;
            this.colNoteContent.HeaderText = "Treść";
            this.colNoteContent.Name = "colNoteContent";
            this.colNoteContent.ReadOnly = true;
            this.colNoteContent.Width = 250;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAddNote);
            this.flowLayoutPanel2.Controls.Add(this.btnEditNote);
            this.flowLayoutPanel2.Controls.Add(this.btnDeleteNote);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(536, 33);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Enabled = false;
            this.btnAddNote.Location = new System.Drawing.Point(3, 3);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(75, 23);
            this.btnAddNote.TabIndex = 0;
            this.btnAddNote.Text = "Dodaj";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnEditNote
            // 
            this.btnEditNote.Enabled = false;
            this.btnEditNote.Location = new System.Drawing.Point(84, 3);
            this.btnEditNote.Name = "btnEditNote";
            this.btnEditNote.Size = new System.Drawing.Size(75, 23);
            this.btnEditNote.TabIndex = 1;
            this.btnEditNote.Text = "Edytuj";
            this.btnEditNote.UseVisualStyleBackColor = true;
            this.btnEditNote.Click += new System.EventHandler(this.btnEditNote_Click);
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Enabled = false;
            this.btnDeleteNote.Location = new System.Drawing.Point(165, 3);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteNote.TabIndex = 2;
            this.btnDeleteNote.Text = "Usuń";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.flowLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zdjęcia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnAddPhoto);
            this.flowLayoutPanel3.Controls.Add(this.btnEditPhoto);
            this.flowLayoutPanel3.Controls.Add(this.btnDeletePhoto);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(536, 33);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Enabled = false;
            this.btnAddPhoto.Location = new System.Drawing.Point(3, 3);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnAddPhoto.TabIndex = 0;
            this.btnAddPhoto.Text = "Dodaj";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // btnEditPhoto
            // 
            this.btnEditPhoto.Enabled = false;
            this.btnEditPhoto.Location = new System.Drawing.Point(84, 3);
            this.btnEditPhoto.Name = "btnEditPhoto";
            this.btnEditPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnEditPhoto.TabIndex = 1;
            this.btnEditPhoto.Text = "Edytuj";
            this.btnEditPhoto.UseVisualStyleBackColor = true;
            this.btnEditPhoto.Click += new System.EventHandler(this.btnEditPhoto_Click);
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.Enabled = false;
            this.btnDeletePhoto.Location = new System.Drawing.Point(165, 3);
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePhoto.TabIndex = 2;
            this.btnDeletePhoto.Text = "Usuń";
            this.btnDeletePhoto.UseVisualStyleBackColor = true;
            this.btnDeletePhoto.Click += new System.EventHandler(this.btnDeletePhoto_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 36);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPhoto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(536, 283);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 5;
            // 
            // dgvPhoto
            // 
            this.dgvPhoto.AllowUserToAddRows = false;
            this.dgvPhoto.AllowUserToDeleteRows = false;
            this.dgvPhoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhotoId,
            this.colPhotoSummary});
            this.dgvPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhoto.Location = new System.Drawing.Point(0, 0);
            this.dgvPhoto.MultiSelect = false;
            this.dgvPhoto.Name = "dgvPhoto";
            this.dgvPhoto.ReadOnly = true;
            this.dgvPhoto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhoto.Size = new System.Drawing.Size(305, 283);
            this.dgvPhoto.TabIndex = 2;
            this.dgvPhoto.SelectionChanged += new System.EventHandler(this.dgvPhoto_SelectionChanged);
            // 
            // colPhotoId
            // 
            this.colPhotoId.DataPropertyName = "Id";
            this.colPhotoId.HeaderText = "#";
            this.colPhotoId.Name = "colPhotoId";
            this.colPhotoId.ReadOnly = true;
            this.colPhotoId.Width = 40;
            // 
            // colPhotoSummary
            // 
            this.colPhotoSummary.DataPropertyName = "Summary";
            this.colPhotoSummary.HeaderText = "Podsumowanie";
            this.colPhotoSummary.Name = "colPhotoSummary";
            this.colPhotoSummary.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.imgPreview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 283);
            this.panel3.TabIndex = 5;
            // 
            // imgPreview
            // 
            this.imgPreview.Location = new System.Drawing.Point(0, 0);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(120, 96);
            this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPreview.TabIndex = 2;
            this.imgPreview.TabStop = false;
            // 
            // PatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PatientList";
            this.Size = new System.Drawing.Size(856, 434);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFamilyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGivenName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFamilyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGivenName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnEditNote;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoteContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Button btnEditPhoto;
        private System.Windows.Forms.Button btnDeletePhoto;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhotoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhotoSummary;
        private System.Windows.Forms.Panel panel3;
        private Emgu.CV.UI.ImageBox imgPreview;
    }
}
