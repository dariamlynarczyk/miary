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
        private Image<Gray, byte> image;

        public PictureView()
        {
            InitializeComponent();
            Image = new Image<Gray, byte>(1, 1);

            cmbScale.Items.AddRange(new object[] { 0.1, 0.25, 0.33, 0.5, 1.0, 2.0, 3.0, 4.0, 10.0 });

            cmbScale.SelectedItem = 1.0;
        }

        public Image<Gray, byte> Image 
        { 
            get
            {
                return image;
            }

            private set
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

        private void btnOpenFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                // image filters
                open.Filter = "Image Files(*.dcm)|*.dcm";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    var dicomData = DICOMFileReader.Read(open.FileName);

                    ushort height = ((UnsignedShort)dicomData.FindFirst(TagHelper.ROWS)).Data;
                    ushort width = ((UnsignedShort)dicomData.FindFirst(TagHelper.COLUMNS)).Data;

                    var interp = ((CodeString)dicomData.FindFirst(TagHelper.PHOTOMETRIC_INTERPRETATION)).Data;

                    if (interp == "MONOCHROME2")
                    {
                        var image = new Image<Gray, byte>(width, height);

                        const int bytesPerPixel = 2;

                        using (var memstream = new MemoryStream())
                        {
                            dicomData.PixelStream.CopyTo(memstream);
                            memstream.Position = 0;

                            byte[] buffer = new byte[width * bytesPerPixel];

                            for (int y = 0; y < height; y++)
                            {
                                memstream.Read(buffer, 0, width * bytesPerPixel);

                                for (int x = 0; x < width; x++)
                                {
                                    var pixel = image[y, x];

                                    double intensity = 0;

                                    for (int i = 0; i < bytesPerPixel; i++)
                                    {
                                        int offset = bytesPerPixel - i - 1;
                                        intensity = intensity * 256 + buffer[x * bytesPerPixel + offset];
                                    }

                                    intensity = intensity / 16;

                                    pixel.Intensity = intensity;
                                    image[y, x] = pixel;
                                }
                            }
                        }
                        // Ta metoda wyrównuje poziomy szarości
                        image._EqualizeHist();
                        Image = image;
                    }
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
