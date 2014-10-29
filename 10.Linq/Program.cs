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

            var tripleNumbers = numbers.Where(number => number % 3 == 0);

            var numberNames = tripleNumbers.Select(number => number.ToWords());

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

            Console.WriteLine("order ------------------------------------------------------");

            var numberNames3 = from number in numbers
                               where number % 2 == 0
                               select new { number, name = number.ToWords() };

            var orderedNames = from numberName in numberNames3
                               orderby numberName.name
                               select numberName.number;
            // or: numberNames3.OrderBy(nn => nn.name)

            foreach (var number in orderedNames)
            {
                Console.WriteLine(number);
            }  
        }
    }
}
