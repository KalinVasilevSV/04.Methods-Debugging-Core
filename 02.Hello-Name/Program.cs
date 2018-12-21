using System;

namespace _02.Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            SayHello(name);
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
