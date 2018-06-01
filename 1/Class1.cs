using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class GeometricFigure //абстрактный класс геометрической фигуры
    {
        public abstract double Area(); //абстрактный метод для вычисления площади
    }

    public class Circle : GeometricFigure //окружность
    {
        double r; //радиус

        public Circle(double r) //конструктор
        {
            this.r = r;
        }

        public override double Area() //определение метода площади
        {
            return Math.PI * r * r;
        }
    }

    public class Triangle : GeometricFigure //треугольник
    {
        double a, b, c;

        public Triangle(double a, double b, double c) //конструктор
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area() //определение метода площади
        {
            if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a) //если треугольник прямоугольный
            {
                if (a * a == b * b + c * c)
                {
                    return b * c / 2;
                }
                else if (b * b == a * a + c * c)
                {
                    return a * c / 2;
                }
                else
                {
                    return a * b / 2;
                }
            }
            else //если треугольник не прямоугольный
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
    }
}
