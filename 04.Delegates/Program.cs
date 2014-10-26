using System;

namespace Delegates
{
    class Program
    {
        static void Main()
        {
            var instance = new MyClass();

            // can refer an instance method
            MyDelegate stringInspector = instance.CountCharacters;
            // apelat ca o funcție; are un singură metodă
            stringInspector("Vasile");

            // can refer static methods
            stringInspector += MyClass.PrintBeginning;
            // apelat cu Invoke; are două funcții
            stringInspector.Invoke("Cozonac");

            stringInspector -= instance.CountCharacters;
            // apelat asincron, just to mess with you
            stringInspector.BeginInvoke(
                "Paranoia",
                ar =>
                {
                    stringInspector.EndInvoke(ar);
                    Console.WriteLine("Am încheiat apelul asincron");
                }, null);

            Console.ReadKey(true);

            // can create anonymous delegates
            stringInspector += delegate (string s)
            {
                Console.WriteLine("„{0}” has {1} characters", s, s.Length);
            };

            stringInspector("masonerie");

            // delegați pre-definiți
            // are un parametru int
            Action<int> action1;
            // are un parametru int, unul string
            Action<int, string> action2;

            // returnează un întreg
            Func<int> func1;
            // are un parametru string, returnează un int
            Func<string, int> func2;
            // un fel de Func<T, bool>
            Predicate<Uri> uriValidator;
        }
    }
}
