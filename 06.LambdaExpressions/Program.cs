using System;
using System.Text;

namespace _06.LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // nici un parametru
            Action action = () => Console.WriteLine("vaca");
            // un parametru
            Action<string> display = s =>
            {
                var message = "Am zis: " + s;
                Console.WriteLine(message);
            };

            action();
            display("batman");

            int i = 0;
            // closure: capturează variabila i
            Func<int> func = () => i++;
            Console.WriteLine(func());
            Console.WriteLine(func());

            // valoare la apel, nu cînd a fost construit delegatul
            i = 123;
            Console.WriteLine(func());
            // am uitat s-o apelez
            Console.WriteLine(func);

            // pot fi explicit în legătură cu tipul parametrilor
            Func<string, int, string> multiply = (string s, int n) =>
            {
                var result = new StringBuilder();
                for (int j = 0; j < n; j++)
                {
                    result.Append(s);
                }

                return result.ToString();
            };

            Console.WriteLine(multiply("Nu", 7));

            return;

            var actions = new Action[3];
            for (int j = 0; j < 3; j++)
            {
                actions[j] = () => Console.Write(j);
            }

            // ce se afișează aici?
            foreach (var a in actions)
            {
                a();
            }

            return;

            var otherActions = new Action[3];
            var index = 0;
            foreach (var c in "abc")
            {
                otherActions[index++] = () => Console.Write(c);
            }

            // dar ce se afișează aici?
            foreach (var a in otherActions)
            {
                a();
            }
        }
    }
}
