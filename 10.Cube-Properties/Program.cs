using System;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string valueSought = Console.ReadLine();

            double result = 0;

            switch(valueSought)
            {
                case "face":
                    result = GetFaceDiagonal(a);
                    break;
                case "space":
                    result = GetSpaceDiagonal(a);
                    break;
                case "volume":
                    result=GetCubeVolume(a);
                    break;
                case "area":
                    result = GetCubeSurfaceArea(a);
                    break;

                default:break;    
            }

            Console.WriteLine($"{result:F2}");
        }

        static double GetFaceDiagonal(double a)
        {
            double faceDiagonal = Math.Sqrt(a * a + a * a);
            return faceDiagonal;
        }

        static double GetSpaceDiagonal(double a)
        {
            double faceDiagonal = Math.Sqrt(a) * Math.Sqrt(a + a);
            double spaceDiagonal = Math.Sqrt(a) * Math.Sqrt(a + (a + a));
            return spaceDiagonal;
        }

        static double GetCubeVolume(double a)
        {
            double cubeVolume = a * a * a;
            return cubeVolume;
        }

        static double GetCubeSurfaceArea(double a)
        {
            double cubeSurfaceArea = (a * a) * 6;
            return cubeSurfaceArea;
        }

    }
}
