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

                                    intensity = intensity / 8;

                                    pixel.Intensity = intensity;
                                    image[y, x] = pixel;
                                }
                            }
                        }

                        Image = image;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog save = new SaveFileDialog())
            {
                // image filters
                //save.Filter = "Image Files(*.dcm)|*.dcm";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Image.Save(save.FileName);
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
        private byte[] ImageToByteArray(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            ImageConverter converter = new ImageConverter();
            return (Image)converter.ConvertFrom(byteArray);
        }
    }
}
