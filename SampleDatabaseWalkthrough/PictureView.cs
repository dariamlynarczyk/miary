using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;
using System.Drawing.Imaging;
using EvilDICOM.Core.IO.Reading;
using EvilDICOM.Core.Helpers;
using EvilDICOM.Core.Element;

namespace SampleDatabaseWalkthrough
{
    public partial class PictureView : UserControl
    {
        private Image<Gray, double> image;

        public PictureView()
        {
            InitializeComponent();
            Image = new Image<Gray, double>(1, 1);

            cmbScale.Items.AddRange(new object[] { 0.1, 0.25, 0.33, 0.5, 1.0, 2.0, 3.0, 4.0, 10.0 });

            cmbScale.SelectedItem = 1.0;
        }

        public Image<Gray, double> Image 
        { 
            get
            {
                return image;
            }

            set
            {
                var oldImage = image;
                var oldBmp = pictureBox.Image;

                image = value;
                pictureBox.Image = image.ToBitmap();

                // Ustawienie kontrolek do przycinania
                nudCropLeft.Value = nudCropRight.Value = nudCropTop.Value = nudCropBottom.Value = 0;
                nudCropLeft.Maximum = nudCropRight.Maximum = image.Width;
                nudCropTop.Maximum = nudCropBottom.Maximum = image.Height;

                // Dla obrazów dla których wysokość lub szerokość <= 3 nie robię nic
                if (image.Width <= 3 || image.Height <= 3)
                {
                    nudWindowSize.Enabled = false;
                    btnDenoise.Enabled = false;
                }
                else
                {
                    nudWindowSize.Minimum = 1;
                    // Tak żeby okno za duże nie było
                    nudWindowSize.Maximum = Math.Min(image.Width, image.Height) / 4;
                    nudWindowSize.Enabled = true;
                    btnDenoise.Enabled = true;
                }

                if (oldImage != null)
                {
                    oldImage.Dispose();
                }

                if (oldBmp != null)
                {
                    oldBmp.Dispose();
                }
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            int shorterSide = Math.Min(Image.Width, Image.Height);

            double angle = (double)nudAngle.Value;            
            var tempImage = Image.Rotate(angle, new Gray(512), false);

            if (angle % 90 == 0)
            {
                Image = tempImage;
            }
            else
            {
                angle = angle % 45;
                double radians = Math.PI * angle / 180.0;

                int newHeight = (int)(Math.Sqrt(Math.Pow(shorterSide, 2) / (Math.Pow(Math.Tan(radians), 2) + 1)));
                int newWidth = (int)(Math.Sqrt(Math.Pow(shorterSide, 2) * Math.Pow(Math.Tan(radians), 2) / (Math.Pow(Math.Tan(radians), 2) + 1)));

                int x = (tempImage.Width / 2) - (newWidth / 2);
                int y = (tempImage.Height / 2) - (newHeight / 2);

                Rectangle rect = new Rectangle(x, y, newWidth, newHeight);
                Image = tempImage.Copy(rect);
            }
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            double scale = Convert.ToDouble(cmbScale.SelectedItem);
            Image = Image.Resize(scale, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
        }
        
        private void btnCrop_Click(object sender, EventArgs e)
        {
            int left = Convert.ToInt32(nudCropLeft.Value);
            int right = Convert.ToInt32(nudCropRight.Value);
            int top = Convert.ToInt32(nudCropTop.Value);
            int bottom = Convert.ToInt32(nudCropBottom.Value);

            int x = left;
            int y = top;
            int width = Image.Width - left - right;
            int height = Image.Height - top - bottom;
            
            if (width < 1 || height < 1)
            {
                MessageBox.Show("Obraz nie może być przycięty");
                return;
            }

            Rectangle rect = new Rectangle(x, y, width, height);
            Image = Image.Copy(rect);
        }

        private void btnDenoise_Click(object sender, EventArgs e)
        {
            int windowSize = (int)nudWindowSize.Value;
            windowSize = 2 * windowSize + 1;

            Image = Image.SmoothBlur(windowSize, windowSize);
        }

        private void btnNoise_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int intensity = (int)nudNoiseIntens.Value;

            var image = Image.Clone();

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    if (r.Next(100) < intensity)
                    {
                        image[j, i] = new Gray(256);
                    }
                }
            }

            Image = image;
        }
    }
}
