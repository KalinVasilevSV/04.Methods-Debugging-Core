using System;

namespace _06.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(n));
        }

        static int Fib(int n)
        {
            int a = 1;
            int b = 1;
            int fib = 0;

            if (n == 0 || n == 1) fib= 1;

            for (int i = 2; i <=n; i++)
            {
                fib = a + b;
                a = b;
                b = fib;
            }

            return fib;
        }
    }
}
