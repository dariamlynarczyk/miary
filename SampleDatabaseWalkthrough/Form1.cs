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
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;

namespace SampleDatabaseWalkthrough
{
    public partial class Form1 : Form
    {
        private PictureView pictureView1;

        private PictureView pictureView2;

        public Form1()
        {
            InitializeComponent();

            pictureView1 = new PictureView();
            pictureView1.Dock = DockStyle.Fill;

            panelPictureView1.Controls.Add(pictureView1);

            pictureView2 = new PictureView();
            pictureView2.Dock = DockStyle.Fill;
            panelPictureView2.Controls.Add(pictureView2);
        }
    }
}
