using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class CircleFitChecker
    {
        public static Boolean Fit(double circleRadius)
        {
            double holeRadius = 5;
            return circleRadius <= holeRadius;
        }
    }
}
