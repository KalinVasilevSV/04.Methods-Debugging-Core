using System;
using System.Numerics;

namespace _12.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }

        static BigInteger Factorial(BigInteger n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
