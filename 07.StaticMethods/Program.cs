using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExtensionMethods.Shorten("Aici scrie ceva", 7));

            Console.WriteLine("Aici scrie ceva".Shorten(5));
        }
    }

    static class ExtensionMethods
    {
        public static string Shorten(this string s, int length)
        {
            return s.Substring(0, length) + "...";
        }
    }
}
