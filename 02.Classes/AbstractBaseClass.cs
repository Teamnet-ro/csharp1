using System;

namespace Classes
{
    // clasele abstracte au membri abstracți
    abstract class AbstractBaseClass
    {
        // funcție abstractă, trebuie suprascrisă
        // de sub-clasele concrete
        protected abstract void PrintInnerMessage();

        // funcție virtuală, poate fi suprascrisă
        // de subclase
        protected virtual void PrintMessageWithDefault()
        {
            Console.WriteLine("Message in ABC");
        }

        // Method Template
        // By default, metodele sunt non-virtuale
        public void PrintMessage()
        {
            Console.WriteLine("Incipit vita brevis");
            PrintInnerMessage();
            PrintMessageWithDefault();
            Console.WriteLine("Gata.");
        }
    }

    // nu mai e abstractă
    class BaseClass : AbstractBaseClass
    {
        // pentru că implementează toate metodele abstracte
        // din clasa de bază
        protected override void PrintInnerMessage()
        {
            Console.WriteLine("This is the base class");
        }
    }

    class OneDerivedClass: BaseClass
    {
        // suprascrie metoda virtuală, nu face nimic
        protected override void PrintInnerMessage()
        {
        }

        // suprascrie metoda virtuală, face altceva
        protected override void PrintMessageWithDefault()
        {
            Console.WriteLine("Message in one derived class");
        }
    }

    class OtherDerivedClass : BaseClass
    {
        // suprascrie metoda virtuală, apelează și
        // metoda din clasa de bază
        protected override void PrintMessageWithDefault()
        {
            base.PrintMessageWithDefault();
            Console.WriteLine("Message in other derived class");
        }
    }

    class ExtraDerivedClass : BaseClass
    {
        // Dacă faci override la o metodă ne-virtuală, nu apare
        // comportamentul polimorfic.
        // se poate și fără new, dar nu e indicat, că e derutant
        public new void PrintMessage()
        {
            Console.WriteLine("I'm extra.");
        }
    }
}
