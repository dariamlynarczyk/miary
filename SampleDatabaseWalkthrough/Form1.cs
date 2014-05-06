using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace SampleDatabaseWalkthrough
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.dcm)|*.dcm";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    // display image in picture box
                    pictureBox1.Image = Image.FromFile(open.FileName);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
