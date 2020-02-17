using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class RectangularBox : Body3D
    {
        internal double Width { get; set; }
        internal double Heigth { get; set; }
        internal double Length { get; set; }

        internal RectangularBox(double width, double heigth, double length)
        {
            this.Width = width;
            this.Heigth = heigth;
            this.Length = length;
        }

        internal override double Square()
        {
            return 2 * (Width * Heigth + Width * Length + Heigth * Length);
        }

        internal override double Volume()
        {
            return Width * Heigth * Length;
        }

        internal override double SumOfEdges()
        {
            return 4 * (Heigth + Width + Length);
        }

    }
}
