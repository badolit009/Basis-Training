using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double GetDiameter(double redias)
        {
            return 2*redias;
        }

        public double GetPerimeter(double redius)
        {
            return 2*Math.PI*redius;

        }

        public double GetArea(double redius)
        {
            return Math.PI*redius*redius;
        }
    }
}
