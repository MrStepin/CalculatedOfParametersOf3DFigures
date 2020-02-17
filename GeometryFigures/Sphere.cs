using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Sphere : Body3D
    {

        internal double Diameter { get; set; }

        double Pi = 3.14;
        

        internal Sphere(double diameter)
        {
            this.Diameter = diameter;

        }

        internal override double Square()
        {
            return Pi * Math.Pow(Diameter, 2);
        }

        internal override double Volume()
        {
            return 4 * Pi * Math.Pow((Diameter / 2), 3);
        }

        internal override double SumOfEdges()
        {
            return 0;
        }
    }
}
