namespace Generics
{
    class Program
    {
        static void Main()
        {
            //for constructors, type parameter needs to be explicitly specified
            var instanceWithInt = new GenericClass<int>(7);
            instanceWithInt.SomeMethod();

            var instanceWithString = new GenericClass<string>("doișpe");
            instanceWithString.SomeMethod();
        }
    }
}
