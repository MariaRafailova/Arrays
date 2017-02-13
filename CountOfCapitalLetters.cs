using System;
using System.Linq;

namespace CountOfCapitalLetters
{
    public class CountOfCapitalLetters
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split()
                .ToArray();
            
            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currWord = words[i];

                if (currWord.Length == 1)
                {
                    char character = currWord[0];
                    if(character >= 65 && character <=90)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
