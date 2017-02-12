﻿using System;
using System.Linq;

namespace ArrayElementsEqualToTheirIndex
{
    public class ArrayElementsEqualToTheirIndex
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i=0; i<numbers.Length; i++)
            {
                if (numbers[i]==i)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
