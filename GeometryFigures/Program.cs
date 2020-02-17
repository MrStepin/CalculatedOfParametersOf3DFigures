using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("This tool calculate:\n1. Square\n2. Volume\n3. Sum of edges\n" +
                              "For Geometry Figures:\n1. Sphere\n2. Tetrahedron\n3. Rectangular box");
            Console.WriteLine("Please input number of Geometry Figure and click 'Enter':");
            int NumberOfFigure = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input number of parameter which you want to calculate and click 'Enter':");
            int UserNumberOfParameter = Convert.ToInt32(Console.ReadLine());



            
            switch (NumberOfFigure)
            {
                case 1:
                    Console.WriteLine("Input diameter of sphere and click 'Enter':\nFor example 23,6");
                    double UserDiameter = Convert.ToDouble(Console.ReadLine());
                    Sphere UserSphere = new Sphere(UserDiameter);
                    switch (UserNumberOfParameter)
                    {
                        case 1:
                            Console.WriteLine(UserSphere.Square());
                            break;
                        case 2:
                            Console.WriteLine(UserSphere.Volume());
                            break;
                        case 3:
                            Console.WriteLine(UserSphere.SumOfEdges());
                            break;
                        default:
                            Console.WriteLine("Entered incorrect number of parameter.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Input length of rib and click 'Enter':\nFor example 23,6");
                    double UserRibLength = Convert.ToDouble(Console.ReadLine());
                    Tetrahedron UserTetrahedron = new Tetrahedron(UserRibLength);
                    switch (UserNumberOfParameter)
                    {
                        case 1:
                            Console.WriteLine(UserTetrahedron.Square());
                            break;
                        case 2:
                            Console.WriteLine(UserTetrahedron.Volume());
                            break;
                        case 3:
                            Console.WriteLine(UserTetrahedron.SumOfEdges());
                            break;
                        default:
                            Console.WriteLine("Entered incorrect number of parameter.");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Input width of rectangular box and click 'Enter':\nFor example 23,6");
                    double UserWidth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input heigth of rectangular box and click 'Enter':\nFor example 23,6");
                    double UserHeigth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input length of rectangular box and click 'Enter':\nFor example 23,6");
                    double UserLength = Convert.ToDouble(Console.ReadLine());


                    RectangularBox UserRectangularBox = new RectangularBox(UserWidth, UserHeigth, UserLength);
                    switch (UserNumberOfParameter)
                    {
                        case 1:
                            Console.WriteLine(UserRectangularBox.Square());
                            break;
                        case 2:
                            Console.WriteLine(UserRectangularBox.Volume());
                            break;
                        case 3:
                            Console.WriteLine(UserRectangularBox.SumOfEdges());
                            break;
                        default:
                            Console.WriteLine("Entered incorrect number of parameter.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Entered incorrect number of figure.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
