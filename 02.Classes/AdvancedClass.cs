using System;
using System.Globalization;

namespace Classes
{
    internal class AdvancedClass:
        NormalClass, ICloneable, IDisposable
    {
        // static: shared by all instances
        private static int howManyInstances;

        // static constructor: runs only once per process,
        // before any class member is accessed the first time
        static AdvancedClass()
        {
            howManyInstances = 0;
        }

        // static method: can be called without creating an instance of the class
        public static void PrintHowManyInstances()
        {
            Console.WriteLine(
                "{0} instances of AdvancedClass were created",
                howManyInstances);

            // ca să putem ști cîte mai sunt „în viață”,
            // ar trebui să adăugăm clasei un finalizer
        }

        // event: will explain later
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
