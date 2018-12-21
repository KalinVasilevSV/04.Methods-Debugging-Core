using System;
using System.Collections.Generic;

namespace _0.Primes_in_a_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNumd = int.Parse(Console.ReadLine());

            List<int> primes = FindPrimesInRange(startNum, endNumd);

            PrintPrimesList(primes);
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes=new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) primes.Add(i);
            }

            return primes;
        }

        static void PrintPrimesList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count - 1) Console.Write(", ");
            }
        }
    }
}
