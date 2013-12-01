using System;

namespace Delegates
{
    class MyClass
    {
        internal void CountCharacters(string s)
        {
            Console.WriteLine(
                "«{0}» are {1} caractere",
                s,
                s.Length);
        }

        internal static void PrintBeginning(string s)
        {
            Console.WriteLine(s.Substring(0, 4));
        }
    }
}
