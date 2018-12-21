using System;
using System.Numerics;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Point A = new Point(x1, y1);
            Point B = new Point(x2, y2);

            GetPointClosestToCenter(A, B);

        }

        struct Point
        {
            public double x, y;

            public Point(double a, double b)
            {
                this.x = a;
                this.y = b;
            }
        }

        static void GetPointClosestToCenter(Point A, Point B)
        {
            double distanceAtoC = Math.Abs(A.x) + Math.Abs(A.y);
            double distanceBtoC = Math.Abs(B.x) + Math.Abs(B.y);

            if (distanceAtoC<=distanceBtoC)
            {
                Console.WriteLine($"({A.x}, {A.y})");
            }
            else
            {
                Console.WriteLine($"({B.x}, {B.y})");
            }
        }
    }
}
