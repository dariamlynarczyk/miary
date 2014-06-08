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

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
               var imageAsByteS1 = PictureView.ImageToByteArray(pictureView1.Image);
               var imageAsByteS2 = PictureView.ImageToByteArray(pictureView2.Image);
                
                   
                    using (NpgsqlCommand cmd = new NpgsqlCommand(""))
                    {
                        cmd.CommandText = @"INSERT INTO tbl_images (nazwa, obraz)
                                    VALUES (@nazwa, @obraz)";

                        cmd.Parameters.AddWithValue("@nazwa", "obraz_1");
                        cmd.Parameters.AddWithValue("@obraz", imageAsBytes1);
                        cmd.Parameters.AddWithValue("@obraz", imageAsBytes2);

                       
                    }
                imageAsByteS1 = Image.Resize(scale, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
                imageAsByteS2 = Image.Resize(scale, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            }

            float[] R(int[] imageAsBytes)
            { 
                float[] sum = new float[imageAsBytes.length];
                for (j=0;j<imageAsBytes.length;j++)
                {
                     sum[j] = 0;
                    for (int i=0; i<N-t[j]; i++)
                 {
                   sum[j] += (x[i]-M)*(x[i+t[j]]-M);
                 }
                 }
             return sum;
           }
        for(int i=0; i<imageAsBytesS1.Length; i++)
                {
                   int korelacja_krzyzowa =0;
                       sum[i,j]=0;
                for(int j=0; j<imageAsBytes2.Length; j++)
                    {
                        korelacja_krzyzowa += (sum[i,j](imageAsBytes1[i,j]* imageAsBytes2[i,j])/Math.Sqrt(((sum(imageAsBytes1[i,j])^2) *sum(imageAsBytes2[i,j])^2)) 
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Wyjątek: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
             */
        }

        private Tuple<Image<Gray, byte>, Image<Gray, byte>> Normalize(Image<Gray, byte> left, Image<Gray, byte> right)
        {
            int width = Math.Max(left.Width, right.Width);
            int height = Math.Max(left.Height, right.Height);

            Image<Gray, byte> result1 = left.Resize(width, height, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            Image<Gray, byte> result2 = right.Resize(width, height, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);

            return new Tuple<Image<Gray, byte>, Image<Gray, byte>>(result1, result2);
        }
    }
}
