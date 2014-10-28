using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;

namespace SampleDatabaseWalkthrough
{
    public partial class Form1 : Form
    {
        private UserControl activectrl;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPictureCompare_Click(object sender, EventArgs e)
        {
            Open(new PictureCompare());
        }

       

        private void Open(UserControl ctrl)
        {
            if (activectrl != null)
            {
                pnlContent.Controls.Remove(activectrl);
                activectrl.Dispose();
            }
            activectrl = ctrl;
            ctrl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(ctrl);
        }
    }
}
