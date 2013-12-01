using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    static class ConstraintExamples
    {
        public static void InterfaceConstraint<T>(T something)
            where T : IDisposable
        {
            something.Dispose();
        }

        public static void ClassConstraint<T>(T reference)
            where T : class
        {
            if (reference != null)
                Console.WriteLine(reference);

            // nu pot crea o instanță nouă, nu știu cum
            //new T();
        }

        public static void StructConstraint<T>(T value)
            where T : struct
        {
            // Nu pot compara cu null, e value type
            //if (value != null)

            var x = new T();
            Console.WriteLine(x.Equals(value));
        }

        public static T NewConstraint<T>()
            where T : new()
        {
            // T poate fi orice tip care are constructor fără parametri
            return new T();
        }
    }
}
