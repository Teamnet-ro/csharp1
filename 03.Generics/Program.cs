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
        }
    }
}
