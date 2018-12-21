using System;

namespace _03.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(numOne, GetMax(numTwo, numThree)));
        }

        static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum > secondNum) return firstNum;
            else return secondNum;
        }
    }
}
