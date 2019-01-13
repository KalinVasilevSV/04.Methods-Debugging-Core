using System;

namespace _14.Debugging_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';  // This was typed with a cyrillic symbol ASCII 1088 instead of the english ASCII 112
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int toPrint = jump + 1;
                    int endIndex = i + toPrint;

                    if (endIndex > text.Length)
                    {
                        toPrint = text.Length-i;
                    }

                    string matchedString = text.Substring(i, toPrint);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
