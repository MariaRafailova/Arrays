using System;
using System.Linq;

namespace CountOccurrencesOfLargerNumbers
{
    public class CountOccurrencesOfLargerNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double p = double.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                if (p< numbers[i])
                {
                    sum += 1;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
