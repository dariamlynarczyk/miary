using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleDatabaseWalkthrough.Measures
{
    public class CrossCorrelation : IMeasure
    {
        public double Compute(double[,] left, double[,] right)
        {
            double sum = 0;
            double sumOfLeftSquares = 0;
            double sumOfRightSquares = 0;

            int width = left.GetLength(0);
            int height = left.GetLength(1);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    sum += left[x, y] * right[x, y];
                    sumOfLeftSquares += Math.Pow(left[x, y], 2);
                    sumOfRightSquares += Math.Pow(right[x, y], 2);
                }
            }

            return sum / Math.Sqrt(sumOfLeftSquares * sumOfRightSquares);
        }
    }
}
