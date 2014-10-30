using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SampleDatabaseWalkthrough.Measures
{
    class HiKwadrat : IMeasure
    {
        public string Name
        {
            get { return "Miara odległości Chi kwadrat"; }
        }

        public double Compute(double[,] left, double[,] right)
        {

            int width = left.GetLength(0);
            int height = left.GetLength(1);

            double sum = 0;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // To zabezpiecza przed dzieleniem przez 0
                    double leftPixel = left[x, y] + 1;
                    double rightPixel = right[x, y] + 1;

                    double sqrDiff = Math.Pow(leftPixel - rightPixel, 2) / (leftPixel + rightPixel);
                    sum += sqrDiff;
                }
            }
            
            return sum;
        }
    }
}
