using System;

namespace _07.Exceptions
{
    class ThrowingClass
    {
        internal void ThrowIf9(int number)
        {
            Console.WriteLine("First message for {0}", number);

            if (number == 9)
            {
                throw new ArgumentException("it was nine", "number");
            }

            Console.WriteLine("Second message for {0}", number);
        }
    }
}
