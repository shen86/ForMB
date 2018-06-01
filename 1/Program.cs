using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricFigure f1, f2, f3, f4, f5;

            f1 = new Circle(5);
            f2 = new Triangle(3, 4, 5);
            f3 = new Triangle(4, 5, 3);
            f4 = new Triangle(5, 3, 4);
            f5 = new Triangle(6, 7, 8);

            Console.WriteLine(f1.Area());
            Console.WriteLine(f2.Area());
            Console.WriteLine(f3.Area());
            Console.WriteLine(f4.Area());
            Console.WriteLine(f5.Area());

            Console.ReadKey();
        }
    }
}
