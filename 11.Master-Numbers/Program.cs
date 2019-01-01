using System;

namespace _11.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool isPalindrome = true;
                bool sumDivisibleSeven = true;
                bool holdsEvenDigit = false;

                string currentIinString = i.ToString();
                int sumOfDigits = 0;

                for (int j = 0; j < currentIinString.Length; j++)
                {
                    if (currentIinString[j] != currentIinString[(currentIinString.Length - 1) - j])
                    {
                        isPalindrome = false;
                        break;
                    }

                    if (int.Parse(currentIinString[j].ToString()) % 2 == 0)
                    { holdsEvenDigit = true; }

                    sumOfDigits += int.Parse(currentIinString[j].ToString());
                }

                if (isPalindrome && holdsEvenDigit && (sumOfDigits % 7 == 0))
                { Console.WriteLine(i); }

            }
        }
    }
}
