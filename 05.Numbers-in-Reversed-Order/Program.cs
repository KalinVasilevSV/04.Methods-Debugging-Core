using System;

namespace _05.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string numDecimal = Console.ReadLine();

            //Bothe methods solve the task in different ways

            PrintInReverse(numDecimal);

            Console.WriteLine(Reversed(numDecimal));
        }

        //Prints the string in reversed order directly
        static void PrintInReverse(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }

        //Returns a reversed string
        static string Reversed(string str)
        {
            string reversed = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            return reversed;
        }
    }
}
