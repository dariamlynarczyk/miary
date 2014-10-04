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

        private void btnCrossCorrelation_Click(object sender, EventArgs e)
        {
            DisplayMeasure(new Measures.CrossCorrelation());
        }

        private void btnMutualInfo_Click(object sender, EventArgs e)
        {
            DisplayMeasure(new Measures.MutualInfo());
        }

        private void btnSquareDiff_Click(object sender, EventArgs e)
        {
            DisplayMeasure(new Measures.SquareDiff());
        }
        
        private void DisplayMeasure(Measures.IMeasure measure)
        {
            var left = pictureView1.Image;
            var right = pictureView2.Image;
            
            int width = Math.Max(left.Width, right.Width);
            int height = Math.Max(left.Height, right.Height);

            double[,] leftArr;

            using (var image = left.Resize(width, height, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR))
            {
                leftArr = ImageToMatrix(image);
            }

            double[,] rightArr;

            using (var image = right.Resize(width, height, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR))
            {
                rightArr = ImageToMatrix(image);
            }

            lblResult.Text = measure.Compute(leftArr, rightArr).ToString();
        }

        private double[,] ImageToMatrix(Image<Gray, double> image)
        {
            double[,] arr = new double[image.Width, image.Height];

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    arr[x, y] = image.Data[y, x, 0];
                }
            }

            return arr;
        }
    }
}
