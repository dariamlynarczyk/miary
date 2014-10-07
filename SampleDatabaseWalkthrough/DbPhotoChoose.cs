using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleDatabaseWalkthrough
{
    public partial class DbPhotoChoose : Form
    {
        public DbPhotoChoose()
        {
            InitializeComponent();

            using(var dataContext = new PatientsEntities())
            {
                cmbPatient.DataSource = (from p in dataContext.Patients
                                         select new SimpleDTO.PatientDTO
                                         {
                                             Id = p.Id,
                                             GivenName = p.GivenName,
                                             FamilyName = p.FamilyName,
                                             BirthDate = p.BirthDate
                                         }).ToList();
            }
        }

        public Image<Gray, double> Image { get; private set; }

        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPatient = cmbPatient.SelectedItem as SimpleDTO.PatientDTO;
            if (selectedPatient != null)
            {
                using (var dataContext = new PatientsEntities())
                {
                    cmbPhoto.DataSource = (from p in dataContext.Pictures
                                             select new SimpleDTO.PhotoDTO
                                             {
                                                 Id = p.Id,
                                                 Summary = p.Summary
                                             }).ToList();
                    cmbPhoto.Enabled = true;
                }
            }
            else
            {
                cmbPhoto.DataSource = Enumerable.Empty<SimpleDTO.PatientDTO>();
                cmbPhoto.Enabled = false;
            }
        }

        private void cmbPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seletedPhoto = cmbPhoto.SelectedItem as SimpleDTO.PhotoDTO;
            if (seletedPhoto != null)
            {
                using (var dataContext = new PatientsEntities())
                {
                    var photo = dataContext.Pictures.Find(seletedPhoto.Id);
                    imgPreview.Image = Image = ConvertHelper.Read(photo.Picture);
                }
            }
            else
            {
                Image = null;
                imgPreview.Image = new Image<Gray, double>(10, 10, new Gray(10));
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Image != null)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Wybierz zdjęcie");
            }
        }
    }
}
