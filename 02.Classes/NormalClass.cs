using System;

namespace Classes
{
    // definiția unei clase
    public class NormalClass
    {
        // field read-only (prefabil ori de cîte ori se poate)
        // private; altfel doar cu un motiv serios
        private readonly int aNumber;

        // proprietate doar cu getter
        // se poate și doar cu setter dar e ciudat
        public int Number
        {
            get { return aNumber; }
        }

        // field mutabil
        private string name;

        // proprietate completă
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                name = value;
            }
        }

        // auto-proprietate
        public bool IsSelected { get; set; }

        // constructor parametrizat
        // Dacă îl șterg, se generează un constructor implicit,
        // fără parametri, care inițializează fieldurile cu zerouri.
        public NormalClass(string name)
        {
            Name = name;
            aNumber = 7;
            IsSelected = true;
        }

        // metodă de instanță
        public void PrintValues()
        {
            Console.WriteLine(
                "Number: {0}, name: {1}, selected: {2}",
                Number,
                Name,
                IsSelected);
        }

        // metodă statică
        public static void PrintStaticMessage()
        {
            Console.WriteLine("Un mesaj static");
        }
    }
}
