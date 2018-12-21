using System;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            Point A = new Point(x1, y1);
            Point B = new Point(x2, y2);
            Line AB = new Line(A, B);

            Point C = new Point(x3, y3);
            Point D = new Point(x4, y4);
            Line CD = new Line(C, D);

            if(AB.length>=CD.length)
            {
                if (GetPointCloserToO(A, B).Equals(A)) Console.WriteLine($"({A.x}, {A.y})({B.x}, {B.y})");
                else Console.WriteLine($"({B.x}, {B.y})({A.x}, {B.y})");
            }
            else
            {
                if (GetPointCloserToO(C, D).Equals(C)) Console.WriteLine($"({C.x}, {C.y})({D.x}, {D.y})");
                else Console.WriteLine($"({D.x}, {D.y})({C.x}, {C.y})");
            }

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

        struct Line
        {
            public Point A, B;
            public double length;

            public Line(Point a, Point b)
            {
                this.A = a;
                this.B = b;
                this.length = Math.Abs(A.x - B.x) + Math.Abs(A.y - B.y);
            }
        }

        static Point GetPointCloserToO(Point A, Point B)
        {
            double distanceAtoO = Math.Abs(A.x) + Math.Abs(A.y);
            double distanceBtoO = Math.Abs(B.x) + Math.Abs(B.y);

            if (distanceAtoO <= distanceBtoO) return A;
            else return B;
        }
    }
}
