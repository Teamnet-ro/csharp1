using System;
using System.IO;

namespace Generics
{
    class Program
    {
        static void Main()
        {
            // for constructors, type parameter needs to be explicitly specified
            var instanceWithInt = new GenericClass<int>(7);
            instanceWithInt.SomeMethod();

            var instanceWithString = new GenericClass<string>("doișpe");
            instanceWithString.SomeMethod();

            // Factory method uses generic type inference:
            // no need to specify type parameters
            var instanceWithFloat = GenericClass.Create(1.23);
            instanceWithFloat.SomeMethod();

            // call MoreGenericMethod with various other types
            instanceWithInt.MoreGenericMethod(333, 1);
            instanceWithInt.MoreGenericMethod(333, "hopa");
            instanceWithInt.MoreGenericMethod(333, 0.001);

            // non-generic classes can have generic methods
            var nonGenericInstance = new NonGenericClass();
            nonGenericInstance.GenericMethod(3);
            nonGenericInstance.GenericMethod(Math.PI);
            nonGenericInstance.GenericMethod("π");

            ConstraintExamples.InterfaceConstraint(new MemoryStream());
        }
    }
}
