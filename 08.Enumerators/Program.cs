﻿using System;
using System.Collections.Generic;

namespace _08.Enumerators
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> list = new List<int>() { 1, 2, 3, 5 };

            foreach (int number in list)
            {
                Console.WriteLine(number);
            }

            var enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}