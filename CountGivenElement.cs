using System;
using System.Linq;

namespace CountGivenElement
{
    public class CountGivenElement
    {
        public static void Main()
        {
            var num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var element = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == element)
                {
                    sum += 1;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
