using System;

namespace _07.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new ThrowingClass();

            o.ThrowIf9(123);

            try
            {
                o.ThrowIf9(9);
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(
                    "Caught something: {0}\nCall stack: {1}",
                    argumentException.Message,
                    argumentException.StackTrace);
            }
            // don't do this
            catch (Exception exception)
            {

            }

            // finally

            // using

            // create your own exception
        }
    }
}
