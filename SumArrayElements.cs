using System;
using System.Linq;

namespace SumArrayElements
{
    public class SumArrayElements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i<n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            var sum = 0;
            for (int i =0; i<n; i++)
            {
                sum += array[i];
            }

            Console.WriteLine(sum);
        }
    }
}
