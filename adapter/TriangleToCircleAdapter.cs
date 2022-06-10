using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class TriangleToCircleAdapter : IAdapter
    {
        private TriangleService triangleService;

        public TriangleToCircleAdapter(TriangleService triangleService)
        {
            this.triangleService = triangleService;
        }

        public CircleService ConvertToCircle()
        {
            double area = (triangleService.triangleBase * triangleService.height) / 2;
                
            double circleCircumference = (2 * Math.Sqrt(area * Math.PI));

            CircleService circle = new CircleService(circleCircumference);

            return circle;
        }
    }
}
