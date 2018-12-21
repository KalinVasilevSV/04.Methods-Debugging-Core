using System;

namespace _07.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long n)
        {
            bool IsPrime = true;

            if (n == 0 || n == 1) IsPrime = false;

            for (int i = 2; i <= Math.Sqrt(n) ; i++)
            {
                if (n % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }

            return IsPrime;
        }
    }
}
