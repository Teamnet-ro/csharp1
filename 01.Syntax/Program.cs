using System;

namespace Syntax
{
    class Program
    {
        static void Main()
        {
            var my = new MyClass();
            my.PrintA();
        }
    }

    class MyClass
    {
        private int a;

        internal void PrintA()
        {
            Console.WriteLine(a);
        }
    }
}
