using System;
using System.Globalization;

namespace Classes
{
    internal class AdvancedClass:
        NormalClass, ICloneable, IDisposable
    {
        private static int howManyInstances;

        static AdvancedClass()
        {
            howManyInstances = 0;
        }

        public static void PrintHowManyInstances()
        {
            Console.WriteLine(
                "{0} instances of AdvancedClass were created",
                howManyInstances);

            // ca să putem ști cîte mai sunt „în viață”,
            // ar trebui să adăugăm clasei un finalizer
        }

        // event
        public event EventHandler CatLeft;

        public string this[int index]
        {
            get
            {
                return index.ToString(CultureInfo.InvariantCulture);
            }
            // poate să aibă și setter
        }

        // Pentru că NormalClass nu are constructor fără
        // parametri, trebuie apelat explicit cel cu.
        public AdvancedClass() : base("avansat")
        {
            howManyInstances = howManyInstances + 1;
            // thread-safe:
            // Interlocked.Increment(ref howManyInstances);
        }

        // A nested class
        private class NestedClass
        {
        }

        #region ICloneable members

        public object Clone()
        {
            var copy = new AdvancedClass();
            copy.IsSelected = this.IsSelected;
            copy.Name = this.Name;

            return copy;
        }

        #endregion

        #region IDisposable members

        // implementarea corectă a IDisposable e umpic
        // mai complicată de atît
        public void Dispose()
        {
            Console.WriteLine("Disposing this object");
        }

        #endregion
    }
}
