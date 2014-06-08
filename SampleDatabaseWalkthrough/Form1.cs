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

        private Tuple<Image<Gray, byte>, Image<Gray, byte>> Normalize(Image<Gray, byte> left, Image<Gray, byte> right)
        {
            int width = Math.Max(left.Width, right.Width);
            int height = Math.Max(left.Height, right.Height);

            Image<Gray, byte> result1 = left.Resize(width, height, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            Image<Gray, byte> result2 = right.Resize(width, height, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);

            return new Tuple<Image<Gray, byte>, Image<Gray, byte>>(result1, result2);
        }

        private void btnCrossCorrelation_Click(object sender, EventArgs e)
        {

        }

        private void btnMutualInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnSquareDiff_Click(object sender, EventArgs e)
        {

        }
    }
}
