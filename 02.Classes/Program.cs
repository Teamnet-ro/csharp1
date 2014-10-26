using System;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            // normal
            NormalClass.PrintStaticMessage();

            var normalObject = new NormalClass("vaca");

            normalObject.PrintValues();

            // advanced
            AdvancedClass.PrintHowManyInstances();
            var advancedObject = new AdvancedClass();
            AdvancedClass.PrintHowManyInstances();

            advancedObject.PrintValues();
            var advancedCopy = (AdvancedClass)advancedObject.Clone();
            advancedCopy.PrintValues();

            AdvancedClass.PrintHowManyInstances();

            advancedCopy.Dispose();
            advancedObject.Dispose();

            // polymorphism
            AbstractBaseClass abcOneDerived = new OneDerivedClass();
            var oneDerived = new OneDerivedClass();

            abcOneDerived.PrintMessage();
            oneDerived.PrintMessage();

            AbstractBaseClass abcOtherDerived = new OtherDerivedClass();
            var otherDerived = new OtherDerivedClass();

            abcOtherDerived.PrintMessage();
            otherDerived.PrintMessage();

            AbstractBaseClass abcExtra = new ExtraDerivedClass();
            var extra = new ExtraDerivedClass();

            abcExtra.PrintMessage();
            extra.PrintMessage();

            // casting
            object o = abcOneDerived;
            // o să arunce InvalidCastException:
            //var s = (string)o;
            // returnează null, nu aruncă excepție:
            var s = o as string;

            Console.WriteLine(
                "o is OneDerivedClass: {0}",
                o is OneDerivedClass);
            Console.WriteLine(
                "o is BaseClass: {0}",
                o is BaseClass);
            Console.WriteLine(
                "o is AbstractBaseClass: {0}",
                o is AbstractBaseClass);
            Console.WriteLine(
                "o is object: {0}",
                o is object);
            Console.WriteLine(
                "o is string: {0}",
                o is string);
        }
    }
}
