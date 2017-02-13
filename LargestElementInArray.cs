using System;
using System.Linq;

namespace LargestElementInArray
{
    public class LargestElementInArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i=0; i<n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(numbers.Max());
        }
    }
}
