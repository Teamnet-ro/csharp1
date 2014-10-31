using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new[]
            {
                "Lucia",
                "Alin",
                "Liviu",
                "Mădălina",
                "Andrei"
            };

            var reversedNames = from name in names
                                where name.Length <= 5
                                select new string(name.Reverse().ToArray());

            foreach (var name in reversedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
