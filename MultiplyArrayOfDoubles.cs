using System;
using System.Linq;

namespace MultiplyArrayOfDoubles
{
    public class MultiplyArrayOfDoubles
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            
            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= p;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
