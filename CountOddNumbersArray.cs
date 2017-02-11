using System;
using System.Linq;

namespace CountOddNumbersArray
{
   public class CountOddNumbersArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var sumOdd = 0;

            for (int i = 0; i<numbers.Length; i++)
            {
                if ( Math.Abs(numbers[i] % 2) == 1)
                {
                    sumOdd +=1;
                }
            }

            Console.WriteLine(sumOdd);
        }
    }
}
