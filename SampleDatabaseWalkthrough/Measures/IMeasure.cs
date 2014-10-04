using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleDatabaseWalkthrough.Measures
{
    public interface IMeasure
    {
        double Compute(double[,] left, double[,] right);
    }
}
