using System;
using System.Collections.Generic;
using System.Linq;

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

            // ... e echivalent cu:
            using (var enumerator = list.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    int number = enumerator.Current;
                    Console.WriteLine(number);
                }
            }

            var collections = new Collections();
            foreach (var dwarf in collections.TheSevenDwarves())
            {
                Console.WriteLine("Here comes {0}", dwarf);
            }

            var fibonacci = collections.Fibonacci();
            var firstFibonacci = collections.FirstTwelve(fibonacci);
            foreach (var n in firstFibonacci)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("------------------------------------------");

            var newFibonacci = collections.Fibonacci();
            var evenFibonacci = collections.OnlyEven(newFibonacci);
            var firstEvenFibonacci = collections.FirstTwelve(evenFibonacci);
            foreach (var n in firstEvenFibonacci)
            {
                Console.WriteLine(n);
            }
        }
    }
}
