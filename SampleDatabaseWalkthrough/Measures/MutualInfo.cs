using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleDatabaseWalkthrough.Measures
{
    public class MutualInfo : IMeasure
    {
        public double Compute(double[,] left, double[,] right)
        {
            double[] leftNorm = NormalizeArray(left);

            double[] rightNorm = NormalizeArray(right);

            var histogram = CreateNormalizedHistogram(leftNorm, rightNorm);

            Dictionary<double, double> xMarg = histogram
                .GroupBy(o => o.Key.Item1)
                .ToDictionary(o => o.Key, o => o.Sum(x => x.Value));

            Dictionary<double, double> yMarg = histogram
                .GroupBy(o => o.Key.Item2)
                .ToDictionary(o => o.Key, o => o.Sum(x => x.Value));

            double xEntropy = -xMarg.Sum(o => o.Value * Math.Log(o.Value + (o.Value == 0 ? 1 : 0), 2));
            double yEntropy = -yMarg.Sum(o => o.Value * Math.Log(o.Value + (o.Value == 0 ? 1 : 0), 2));

            double xyEntropy =
                histogram.Sum(o => -(o.Value * Math.Log(o.Value + (o.Value == 0 ? 1 : 0), 2)));

            return xEntropy + yEntropy - xyEntropy;
        }

        private double[] NormalizeArray(double[,] array)
        {
            double min = array[0, 0];
            double[] normalized = new double[array.Length];
            int counter = 0;

            foreach (double value in array)
            {
                normalized[counter] = value;
                if (value < min)
                {
                    min = value;
                }
                counter++;
            }

            for (int i = 0; i < normalized.Length; i++)
            {
                normalized[i] = normalized[i] - min + 1;
            }

            return normalized;
        }

        private Dictionary<Tuple<double, double>, double> CreateNormalizedHistogram(double[] left, double[] right)
        {
            Dictionary<Tuple<double, double>, int> histogram = new Dictionary<Tuple<double, double>, int>();

            for (int i = 0; i < left.Length; i++)
            {
                double leftItem = left[i];
                double rightItem = right[i];
                var key = Tuple.Create(leftItem + 1, rightItem + 1);

                int val;
                histogram.TryGetValue(key, out val);

                histogram[key] = val + 1;
            }

            double sum = histogram.Sum(o => o.Value);

            return histogram.ToDictionary(o => o.Key, o => (o.Value / sum));
        }
    }
}
