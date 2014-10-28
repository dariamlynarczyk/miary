using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SampleDatabaseWalkthrough.Measures
{
    class HiKwadrat:IMeasure
    {
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

            // suma może przyjmować wartości od 0 do 256*256 
            // nie wiem czy nie lepiej byłoby zastosować inne przekształcenie niż liniowe ale niech będzie
            return sum / 256;
        }
    }
}
