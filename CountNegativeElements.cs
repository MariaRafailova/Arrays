using System;
using System.Linq;

namespace CountNegativeElements
{
    public class CountNegativeElements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            int sumNegative = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] < 0)
                {
                    sumNegative += 1;
                }
            }

            Console.WriteLine(sumNegative);
        }
    }
}
