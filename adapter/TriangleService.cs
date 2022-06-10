using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class TriangleService
    {
        public double triangleBase;
        public double height;
        public TriangleService(double triangleBase, double height)
        {
            this.triangleBase = triangleBase;
            this.height = height;
        }
    }
}
