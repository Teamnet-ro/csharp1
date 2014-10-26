using System;

namespace Generics
{
    class NonGenericClass
    {
        // metodele din clasele non-generice pot fi generice
        public void GenericMethod<T>(T something)
        {
            Console.WriteLine(
                "NonGenericClass.GenericMethod({0}) {1}",
                something.GetType(),
                something);
        }
    }
}
