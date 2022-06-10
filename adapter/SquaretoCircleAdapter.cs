using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class SquaretoCircleAdapter : IAdapter
    {
        private SquareService squareService;

        public SquaretoCircleAdapter(SquareService squareService)
        {
            this.squareService = squareService;
        }

        public CircleService ConvertToCircle()
        {
           double circleCircumference = (2 *Math.Sqrt(squareService.area*Math.PI));

            CircleService circle = new CircleService(circleCircumference);

           return circle;
        }
    }
}
