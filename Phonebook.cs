using System;
using System.Linq;

namespace Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var phones = Console.ReadLine().Split().ToArray();
            var names = Console.ReadLine().Split().ToArray();

            string input = Console.ReadLine();

            while (input != "done")
            {
                PrintElement(names, phones, input);

                input = Console.ReadLine();
            }
        }

        public static void PrintElement(string[] names, string[] phones, string input)
        {
           for (int i=0; i<names.Length; i++)
            {
                if (names[i]==input)
                {
                    Console.WriteLine("{0} -> {1}", names[i], phones[i]);
                }

            }
        }
    }
}

