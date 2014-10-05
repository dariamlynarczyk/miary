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
            dgvNotes.AutoGenerateColumns = false;
            dgvPhoto.AutoGenerateColumns = false;
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

        public SimpleDTO.NoteDTO SelectedNote
        {
            get
            {
                SimpleDTO.NoteDTO selected = null;

                var selectedRow = dgvNotes.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

                if (selectedRow != null)
                {
                    selected = selectedRow.DataBoundItem as SimpleDTO.NoteDTO;
                }

                return selected;
            }
        }

        #region Patients

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

        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            var selected = SelectedPatient;

            if (selected != null)
            {
                lblGivenName.Text = selected.GivenName;
                lblFamilyName.Text = selected.FamilyName;
                lblBirthDate.Text = selected.BirthDate.ToShortDateString();

                btnEditPatient.Enabled =
                    btnDeletePatient.Enabled =
                    btnAddNote.Enabled =
                    btnAddPhoto.Enabled =
                    true;
            }
            else
            {
                lblGivenName.Text = lblFamilyName.Text = lblBirthDate.Text = string.Empty;
                btnEditPatient.Enabled =
                    btnDeletePatient.Enabled =
                    btnAddNote.Enabled =
                    btnAddPhoto.Enabled =
                    false;
            }

            RefreshNotes();
            RefreshPhotos();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            var patient = new Patients();
            patient.BirthDate = DateTime.Today;

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
                        dataContext.SaveChanges();

                        RefreshPatientList(dataContext);
                    }
                }
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy usunąć klienta?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var dataContext = new PatientsEntities())
                {
                    var selected = SelectedPatient;

                    var patient = dataContext.Patients.Find(selected.Id);

                    dataContext.Patients.Remove(patient);
                    dataContext.SaveChanges();

                    RefreshPatientList(dataContext);
                }
            }
        } 
        #endregion

        #region Notes
        private void RefreshNotes()
        {
            using (var datacontext = new PatientsEntities())
            {
                RefreshNotes(datacontext);
            }
        }

        private void RefreshNotes(PatientsEntities dataContext)
        {
            var patient = SelectedPatient;
            if (patient != null)
            {
                dgvNotes.DataSource = (from note in dataContext.Notes
                                       where note.PatientId == patient.Id
                                       select new SimpleDTO.NoteDTO
                                       {
                                           Id = note.Id,
                                           Content = note.Content
                                       }).ToList();
            }
            else
            {
                dgvNotes.DataSource = Enumerable.Empty<SimpleDTO.NoteDTO>();
            }
        }

        private void dgvNotes_SelectionChanged(object sender, EventArgs e)
        {
            var selected = SelectedNote;

            if (selected != null)
            {
                btnEditNote.Enabled = btnDeleteNote.Enabled = true;
            }
            else
            {
                btnEditNote.Enabled = btnDeleteNote.Enabled = false;
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            Notes note = new Notes();
            note.PatientId = SelectedPatient.Id;

            using (var dlg = new NoteEdit(note))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using(var dataContext = new PatientsEntities())
                    {
                        dataContext.Notes.Add(note);
                        dataContext.SaveChanges();

                        RefreshNotes(dataContext);
                    }
                }
            }
        }

        private void btnEditNote_Click(object sender, EventArgs e)
        {
            using (var dataContext = new PatientsEntities())
            {
                var note = dataContext.Notes.Find(SelectedNote.Id);

                using (var dlg = new NoteEdit(note))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        dataContext.SaveChanges();
                        RefreshNotes(dataContext);
                    }
                }
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy usunąć notatkę?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var dataContext = new PatientsEntities())
                {
                    var patient = dataContext.Notes.Find(SelectedNote.Id);

                    dataContext.Notes.Remove(patient);
                    dataContext.SaveChanges();

                    RefreshPatientList(dataContext);
                }
            }
        }

        #endregion

        #region Photos

        private void RefreshPhotos()
        {
            using (var datacontext = new PatientsEntities())
            {
                RefreshPhotos(datacontext);
            }
        }

        private void RefreshPhotos(PatientsEntities dataContext)
        {

        }

        #endregion
    }
}
