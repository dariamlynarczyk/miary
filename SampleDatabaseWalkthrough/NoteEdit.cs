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
    public partial class NoteEdit : Form
    {
        private Notes note;

        public NoteEdit(Notes note)
        {
            InitializeComponent();
            this.note = note;

            tbContent.Text = note.Content;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            StringBuilder validationBuilder = new StringBuilder();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(tbContent.Text))
            {
                validationBuilder.AppendLine("Uzupełnij imię");
                valid = false;
            }
            
            if (valid)
            {
                note.Content = tbContent.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Popraw błędy:\r\n" + validationBuilder.ToString());
            }
        }
    }
}
