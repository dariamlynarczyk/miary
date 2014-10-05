using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleDatabaseWalkthrough
{
    public partial class PatientList : UserControl
    {
        public PatientList()
        {
            InitializeComponent();
            dgvPatients.AutoGenerateColumns = false;
            RefreshPatientList();
        }

        public SimpleDTO.PatientDTO SelectedPatient
        {
            get
            {
                SimpleDTO.PatientDTO selected = null;

                var selectedRow = dgvPatients.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

                if (selectedRow != null)
                {
                    selected = selectedRow.DataBoundItem as SimpleDTO.PatientDTO;
                }
                return selected;
            }
        }

        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            var selected = SelectedPatient;

            if (selected != null)
            {
                lblGivenName.Text = selected.GivenName;
                lblFamilyName.Text = selected.FamilyName;
                lblBirthDate.Text = selected.BirthDate.ToShortDateString();

                btnEditPatient.Enabled = btnDeletePatient.Enabled = true;
            }
            else
            {
                lblGivenName.Text = lblFamilyName.Text = lblBirthDate.Text = string.Empty;
                btnEditPatient.Enabled = btnDeletePatient.Enabled = false;
            }
        }

        private void RefreshPatientList()
        {
            using (var datacontext = new PatientsEntities())
            {
                RefreshPatientList(datacontext);
            }
        }

        private void RefreshPatientList(PatientsEntities dataContext)
        {
            dgvPatients.DataSource = (from p in dataContext.Patients
                                      select new SimpleDTO.PatientDTO
                                      {
                                          Id = p.Id,
                                          FamilyName = p.FamilyName,
                                          GivenName = p.GivenName,
                                          BirthDate = p.BirthDate
                                      }).ToList();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            var patient = new Patients();

            using (var dlg = new PatientEdit(patient))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (var datacontext = new PatientsEntities())
                    {
                        datacontext.Patients.Add(patient);
                        datacontext.SaveChanges();

                        RefreshPatientList(datacontext);
                    }
                }
            }
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            using (var dataContext = new PatientsEntities())
            {
                var selected = SelectedPatient;

                var patient = dataContext.Patients.Find(selected.Id);

                using (var dlg = new PatientEdit(patient))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        using (var datacontext = new PatientsEntities())
                        {
                            datacontext.Patients.Add(patient);
                            datacontext.SaveChanges();

                            RefreshPatientList(datacontext);
                        }
                    }
                }
            }
        }
    }
}
