﻿using System;
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
            DisplayMeasure(ComputeCrossCorrelation);
        }

        private double ComputeCrossCorrelation(double[,] left, double[,] right, int maskSize)
        {

            return 0;
        }

        private void btnMutualInfo_Click(object sender, EventArgs e)
        {
            DisplayMeasure(ComputeMutualInfo);
        }

        private double ComputeMutualInfo(double[,] left, double[,] right, int maskSize)
        {
            return 0;
        }

        private void btnSquareDiff_Click(object sender, EventArgs e)
        {
            DisplayMeasure(ComputeSquareDiff);
        }

        private double ComputeSquareDiff(double[,] left, double[,] right, int maskSize)
        {
            double sum = 0;
            for (int x = 0; x < maskSize; x++)
            {
                for (int y = 0; y < maskSize; y++)
                {
                    double sqrDiff = Math.Pow(left[x, y] - right[x, y], 2);
                    sum += sqrDiff;
                }
            }

            sum = sum / (maskSize * maskSize);

            return sum;
        }

        private void DisplayMeasure(Func<double[,], double[,], int, double> measure)
        {
            var left = pictureView1.Image;
            var right = pictureView2.Image;
            
            int width = Math.Max(left.Width, right.Width);
            int height = Math.Max(left.Height, right.Height);

            var image1 = left.Resize(width, height, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            var image2 = right.Resize(width, height, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            
            const int maskRadius = 5;
            const int maskSize = maskRadius + 1 + maskRadius;

            if (width < maskSize || height < maskSize)
            {
                MessageBox.Show("Obrazy za małe na przeprowadzenie analizy");
                return;
            }

            using (Image<Gray, byte> result = new Image<Gray, byte>(width - 2 * maskRadius, height - 2 * maskRadius))
            {
                for (int x1 = 0; x1 < width - maskSize; x1++)
                {
                    for (int y1 = 0; y1 < height - maskSize; y1++)
                    {
                        

                        double[,] partOfLeft = new double[maskSize, maskSize];
                        double[,] partOfRight = new double[maskSize, maskSize];

                        for (int x2 = 0; x2 < maskSize; x2++)
                        {
                            for (int y2 = 0; y2 < maskSize; y2++)
                            {
                                int row = y1 + y2;
                                int column = x1 + x2;
                                partOfLeft[x2, y2] = image1[row, column].Intensity;
                                partOfRight[x2, y2] =  image2[row, column].Intensity;
                            }
                        }

                        result[y1, x1] = new Gray(measure(partOfLeft, partOfRight, maskSize));
                    }
                }

                result._EqualizeHist();
                pbResult.Image = result.ToBitmap();
            }
            image1.Dispose();
            image2.Dispose();
        }
    }
}
