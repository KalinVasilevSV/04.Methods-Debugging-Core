using System;
using System.Numerics;

namespace _13.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(TrailingZeroes(Factorial(n)));
        }

        static BigInteger Factorial(BigInteger n)
        {
            BigInteger factorial = 1;

            if (n == 0) return factorial;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static BigInteger TrailingZeroes(BigInteger n)
        {
            string nString = n.ToString();
            BigInteger trailingZeroes = 0;

            for (int i = (nString.Length - 1); i >= 0; i--)
            {
                if (nString[i] == '0') trailingZeroes++;
                else break;
            }

            return trailingZeroes;
        }
    }
}
