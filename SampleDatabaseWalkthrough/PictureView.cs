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
            double angle = (double)nudAngle.Value;
            Image = Image.Rotate(angle, new Gray(512), false);
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
            // Dla obrazów dla których wysokość lub szerokość <= 3 nie robię nic
            if (Image.Width <= 3 || Image.Height <= 3)
            {
                return;
            }

            int windowSize;
            // Dla małych obrazów wykorzystuję okno mniejsze od połowy mniejszego wymiaru
            if (Image.Width <= 10 || Image.Height <= 10)
            {
                windowSize = Math.Min(Image.Width, Image.Height) / 2;
            }
            else
            {
                windowSize = 5;
            }

            //Image = Image.SmoothMedian(windowSize);
            Image = Image.SmoothBlur(windowSize, windowSize);
        }
    }
}
