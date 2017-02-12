using System;
using System.Linq;

namespace Last3ConsecutiveEqualStrings
{
    public class Last3ConsecutiveEqualStrings
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split().ToArray();

            string[] last3 = new string[3];

            for (int i = 0; i < text.Length - 2; i++)
            {
                if (text[i] == text[i + 1] && text[i + 1] == text[i + 2])
                {
                    last3[0] = text[i];
                    last3[1] = text[i];
                    last3[2] = text[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write(last3[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

