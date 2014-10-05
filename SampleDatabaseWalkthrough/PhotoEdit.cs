using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleDatabaseWalkthrough
{
    public partial class PhotoEdit : Form
    {
        private byte[] pictureBytes;

        private Pictures picture;

        public PhotoEdit(Pictures picture)
        {
            InitializeComponent();
            this.picture = picture;
            tbSummary.Text = picture.Summary;
            pictureBytes = picture.Picture;

            if (pictureBytes != null)
            {
                picureBox.Image = ConvertHelper.Read(pictureBytes);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "DICOM files|*.dcm";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBytes = File.ReadAllBytes(ofd.FileName);
                    picureBox.Image = ConvertHelper.Read(pictureBytes);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StringBuilder validationBuilder = new StringBuilder();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(tbSummary.Text))
            {
                validationBuilder.AppendLine("Uzupełnij imię");
                valid = false;
            }

            if (pictureBytes == null)
            {
                validationBuilder.AppendLine("Wybierz zdjęcie");
                valid = false;
            }

            if (valid)
            {
                picture.Summary = tbSummary.Text;
                picture.Picture = pictureBytes;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Popraw błędy:\r\n" + validationBuilder.ToString());
            }
        }
    }
}
