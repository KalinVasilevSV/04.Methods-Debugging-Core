using System;

namespace _15.Debugging_Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();

            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');
                int currentArg = 0;

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                    default:break;
                }

                Console.WriteLine(result);

                opCode = Console.ReadLine();
            }
        }
    }
}
