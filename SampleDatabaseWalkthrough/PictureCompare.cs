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
                ofd.Filter = "Pliki DICOM|*.dcm|JPG|*.jpg;*.jpeg;|PNG|*.png|TIFF|*.tif|BMP|*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // to dla jpeg, bmp, i innych
                    pictureView1.Image = new Image<Gray, byte>(ofd.FileName).Convert<Gray, double>(); 

                    // to dla DICOM
                    //pictureView1.Image = ConvertHelper.Read(ofd.FileName);
                }
            }
        }

        private void btnOpenFile2_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Pliki DICOM|*.dcm|JPG|*.jgp;*.jpeg|PNG|*.png|TIFF|*.tif|BMP|*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // to dla jpeg, bmp, i innych
                    pictureView2.Image = new Image<Gray, byte>(ofd.FileName).Convert<Gray, double>();

                    // to dla DICOM
                    //pictureView2.Image = ConvertHelper.Read(ofd.FileName);
                }
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            using(var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Pliki JPEG|*.jpg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //ConvertHelper.Write(pictureView1.Image, sfd.FileName);
                    pictureView1.Image.Save(sfd.FileName);
                }
            }
        }


        private void btnSave2_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Pliki JPEG|*.jpg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //ConvertHelper.Write(pictureView2.Image, sfd.FileName);
                    pictureView2.Image.Save(sfd.FileName);
                }
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
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

            var measures = new Measures.IMeasure[] 
            {
                new Measures.CrossCorrelation(),
                new Measures.HiKwadrat(),
                new Measures.MutualInfo(),
                new Measures.SquareDiff()
            };

            var sbResult = new StringBuilder();

            foreach (var measure in measures)
            {
                sbResult.Append(measure.Name);
                sbResult.Append(": ");
                sbResult.AppendLine(measure.Compute(leftArr, rightArr).ToString());
            }

            tbResult.Text = sbResult.ToString();
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
