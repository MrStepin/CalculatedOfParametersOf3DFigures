using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Tetrahedron : Body3D
    {
        internal double RibLength { get; set; }

        internal Tetrahedron(double riblength)
        {
            this.RibLength = riblength;

        }

        internal override double Square()
        {
            return Math.Pow(RibLength, 2) * Math.Sqrt(3);
        }

        internal override double Volume()
        {
            return (Math.Pow(RibLength, 3) * Math.Sqrt(2)) / 12;
        }

        internal override double SumOfEdges()
        {
            return 6 * RibLength;
        }
    }
}
