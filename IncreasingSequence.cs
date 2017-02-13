using System;
using System.Linq;

namespace IncreasingSequence
{
    public class IncreasingSequence
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            bool increasing = true;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] >= numbers[i+1])
                {
                    increasing = false;
                    break;
                }                
            }

            if (increasing)
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
