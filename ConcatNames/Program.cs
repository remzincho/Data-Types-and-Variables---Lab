﻿using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string last = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine($"{first}{delimiter}{last}");
        }
    }
}
