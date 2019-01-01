using System;

namespace _11.Master_Numbers_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool isPalindrome = IsPalindrome(i);
                if (!isPalindrome) continue;

                bool hasEvenDigit = HasEvenDigit(i);
                if (!hasEvenDigit) continue;

                bool sumDividedBySeven = SumDividedBySeven(i);
                if (!sumDividedBySeven) continue;

                if (isPalindrome && hasEvenDigit && sumDividedBySeven)
                    Console.WriteLine(i);
            }
        }

        static bool IsPalindrome(int num)
        {
            string numString = num.ToString();

            for (int i = 0; i < numString.Length; i++)
            {
                if (numString[i] != numString[(numString.Length - 1) - i])
                    return false;
            }

            return true;
        }

        static bool HasEvenDigit(int num)
        {
            string numString = num.ToString();

            for (int i = 0; i < numString.Length; i++)
            {
                if (numString[i] % 2 == 0)
                    return true;
            }

            return false;
        }

        static bool SumDividedBySeven(int num)
        {
            string numString = num.ToString();
            int sumOfDigits = 0;

            for (int i = 0; i < numString.Length; i++)
            {
                sumOfDigits += int.Parse(numString[i].ToString());
            }

            if (sumOfDigits % 7 == 0)
                return true;
            else
                return false;
        }

    }
}
