using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;

namespace SampleDatabaseWalkthrough
{
    public partial class PictureCompare : UserControl
    {
        private PictureView pictureView1;

        private PictureView pictureView2;

        public PictureCompare()
        {
            InitializeComponent();

            pictureView1 = new PictureView();
            pictureView1.Dock = DockStyle.Fill;
            pnlPictureView1.Controls.Add(pictureView1);

            pictureView2 = new PictureView();
            pictureView2.Dock = DockStyle.Fill;
            pnlPictureView2.Controls.Add(pictureView2);
        }

        private void btnOpenFile1_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Pliki DICOM|*.dcm";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureView1.Image = ConvertHelper.Read(ofd.FileName);
                }
            }
        }

        private void btnOpenFile2_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Pliki DICOM|*.dcm";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureView2.Image = ConvertHelper.Read(ofd.FileName);
                }
            }
        }

       
        private void btnCrossCorrelation_Click(object sender, EventArgs e)
        {
            DisplayMeasure(new Measures.CrossCorrelation());
        }

        private void btnMutualInformation_Click(object sender, EventArgs e)
        {
            DisplayMeasure(new Measures.MutualInfo());
        }

        private void btnSquareDiffSum_Click(object sender, EventArgs e)
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
