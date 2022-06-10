using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal class AdapterFactory
    {
        public IAdapter getAdapter(dynamic shape)
        {
            if (shape is SquareService)
            {
                return new SquaretoCircleAdapter(shape);
            }
            if (shape is TriangleService)
            {
                return new TriangleToCircleAdapter(shape);
            }

            throw new ArgumentException("Unknown service");
        }
    }
}
