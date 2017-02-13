using System;
using System.Linq;

namespace ArraySymmetry
{
    public class ArraySymmetry
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split()
                .ToArray();

            bool equal = true;
            for (int i = 0; i < words.Length/2; i++)
            {
                if (words[i] != words[words.Length-1 -i])
                {
                    equal = false;
                    break;
                }
            }

            if (equal)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
