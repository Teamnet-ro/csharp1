using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using Humanizer;

namespace _10.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es");

            var numbers = Enumerable.Range(1, 20);

            numbers = numbers.Where(number => number % 3 == 0);

            var numberNames = numbers.Select(number => number.ToWords());

            foreach (var numberName in numberNames)
            {
                Console.WriteLine(numberName);
            }

            Console.WriteLine("or... ------------------------------------------------------");

            var numberNames2 = from number in numbers
                               where number % 3 == 0
                               select number.ToRoman();

            foreach (var numberName in numberNames2)
            {
                Console.WriteLine(numberName);
            }
        }
    }
}
