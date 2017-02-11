using System;
using System.Linq;

namespace SmallestElementInArray
{
    public class SmallestElementInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(numbers.Min());
        }
    }
}
