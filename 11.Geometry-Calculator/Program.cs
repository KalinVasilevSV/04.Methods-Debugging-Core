using System;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            double area = 0.0;

            switch (figureType)
            {
                case "triangle":
                    area = TriangleArea();
                    break;
                case "square":
                    area = SquareArea();
                    break;
                case "rectangle":
                    area = RectangleArea();
                    break;
                case "circle":
                    area = CircleArea();
                    break;

                default: break;
            }

            Console.WriteLine($"{area:F2}");
        }

        static double TriangleArea()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = (a * h) / 2;

            return area;
        }

        static double SquareArea()
        {
            double a = double.Parse(Console.ReadLine());

            double area = a * a;

            return area;
        }

        static double RectangleArea()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = a * b;

            return area;
        }

        static double CircleArea()
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;

            return area;
        }
    }
}
