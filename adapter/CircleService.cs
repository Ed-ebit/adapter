using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class CircleService
    {
        public double circumference;
        public double radius;
        public CircleService(double circumference)
        {
            this.circumference = circumference;
            this.radius = (circumference /(2*Math.PI));
        }

    }
}
