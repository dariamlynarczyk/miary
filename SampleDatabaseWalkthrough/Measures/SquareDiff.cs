using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleDatabaseWalkthrough.Measures
{
    public class SquareDiff : IMeasure
    {

        public string Name
        {
            get { return "Suma kwadratów różnic"; }
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
                    double sqrDiff = Math.Pow(left[x, y] - right[x, y], 2);
                    sum += sqrDiff;
                }
            }

            sum = sum / (width * height);

            return sum / 256;
        }
    }
}
