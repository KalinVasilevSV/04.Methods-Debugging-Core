using System;
using System.Linq;

namespace _17.Debuggin_Sequence_of_Commmands
{
    class Program
    {
        //Very proud of this solution as well

        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            //Count of numbers in the collection
            int sizeOfArray = int.Parse(Console.ReadLine());

            //String of numbers transformed to array
            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();


            while (true) //Had "over" as sentinel
            {
                string[] command = Console.ReadLine().Trim().Split(); //Gets the full command <action><position><value>
                string action = command[0];

                int[] args = new int[2];

                if (action == "stop")
                {
                    break;
                }
                else if (action.Equals("add") ||
                         action.Equals("subtract") ||
                         action.Equals("multiply"))
                {
                    args[0] = int.Parse(command[1]); //Had wrong params assigned to args
                    args[1] = int.Parse(command[2]);

                    goto PerformAction;
                    //Had a likely unnecessary call of PerformAction()
                }
                else if (action.Equals("lshift") ||
                        action.Equals("rshift"))
                {
                    goto PerformAction;
                }
                else continue;

                PerformAction:
                    PerformAction(array, action, args);

                PrintArray(array);
                Console.Write('\n');

            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr; //This was the remainder of the line -> .Clone() as long[];
            int pos = args[0]-1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
                default: break;
            }
        }

        private static void ArrayShiftRight(long[] array) // Shifts the array without shifting the first element, leaving the last iterated element unchanged
        {
            long shiftedElement = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = shiftedElement;
        }

        private static void ArrayShiftLeft(long[] array) // Shifts the array without shifting the first element, leaving the last iterated element unchanged
        {
            long shiftedElement = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = shiftedElement;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
