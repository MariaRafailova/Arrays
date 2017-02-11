using System;
using System.Linq;

namespace RotateArrayOfStrings
{
    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().ToArray();
            
            var rotated = new string[array.Length];
            
            for (int i = 0; i < array.Length - 1; i++)

                rotated[i + 1] = array[i];
            
            var last = array[rotated.Length - 1];
            
            rotated[0] = last;

            Console.WriteLine(string.Join(" ", rotated));
            
        }
    }
}
