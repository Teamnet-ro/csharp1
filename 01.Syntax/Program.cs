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
        // fields are automatically initialized to zero / null
        int a;

        internal void PrintA()
        {
            Console.WriteLine(a);
        }
    }
}
