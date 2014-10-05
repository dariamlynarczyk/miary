using System;
using System.Text;
using System.Windows.Forms;

namespace SampleDatabaseWalkthrough
{
    public partial class PatientEdit : Form
    {
        Patients patient;

        public PatientEdit(Patients patient)
        {
            InitializeComponent();
            this.patient = patient;
            tbGivenName.Text = patient.GivenName;
            tbFamilyName.Text = patient.FamilyName;
            dtpBirthDate.Value = patient.BirthDate;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StringBuilder validationBuilder = new StringBuilder();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(tbGivenName.Text))
            {
                validationBuilder.AppendLine("Uzupełnij imię");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(tbFamilyName.Text))
            {
                validationBuilder.AppendLine("Uzupełnij nazwisko");
                valid = false;
            }

            if (valid)
            {
                patient.GivenName = tbGivenName.Text;
                patient.FamilyName = tbFamilyName.Text;
                patient.BirthDate = dtpBirthDate.Value;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Popraw błędy:\r\n" + validationBuilder.ToString());
            }
        }
    }
}