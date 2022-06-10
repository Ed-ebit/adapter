using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class SquareService
    {
        public double sideLength;
        public double area;
        public SquareService(double sideLength)
        {
            this.sideLength = sideLength;
            this.area = sideLength*sideLength;
        }

    }
}
