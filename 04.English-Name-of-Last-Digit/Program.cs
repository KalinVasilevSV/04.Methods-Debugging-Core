using System;

namespace _04.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string num =Console.ReadLine();

            Console.WriteLine(NameOfLastDigit(num));
        }

        static string NameOfLastDigit(string num)
        {
            char lastDigit = num[num.Length-1];
            switch(lastDigit)
            {
                case '0': return "zero";
                case '1': return "one";
                case '2': return "two";
                case '3': return "three";
                case '4': return "four";
                case '5': return "five";
                case '6': return "six";
                case '7': return "seven";
                case '8': return "eight";
                case '9': return "nine";
                default: return "no value  found";
            }
        }
    }
}
