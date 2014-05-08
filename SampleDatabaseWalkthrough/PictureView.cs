﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

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
                //open.Filter = "Image Files(*.dcm)|*.dcm";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (Image<Bgr, Byte> image = new Image<Bgr, byte>(open.FileName))
                    {
                        Image = image.Convert<Gray, byte>();
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
    }
}
