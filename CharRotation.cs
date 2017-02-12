using System;
using System.Linq;

namespace CharRotation
{
    public class CharRotation
    {
        public static void Main()
        {
            var letters = Console.ReadLine().ToCharArray();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    result = letters[i] - numbers[i];
                    Console.Write((char)result);
                }

                if (numbers[i] % 2 != 0)
                {
                    result = letters[i] + numbers[i];
                    Console.Write((char)result);
                }
            }

            Console.WriteLine();
        }
    }
}
