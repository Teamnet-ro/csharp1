using System;
using System.IO;
using System.Numerics;

namespace _11.Async
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var file = File.Open(@"..\..\Program.cs", FileMode.Open))
            using (var reader = new StreamReader(file))
            {
                var lineTask = reader.ReadLineAsync();
                // do other stuff
                BigInteger x = 0;
                while (!lineTask.IsCompleted)
                {
                    x = x + 1;
                }

                var line = lineTask.Result;
                Console.WriteLine("Am ajuns la {0}, am citit {1}", x, line);
            }
        }
    }
}
