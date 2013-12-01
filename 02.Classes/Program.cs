using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            NormalClass.PrintStaticMessage();

            var normalObject = new NormalClass("vaca");

            normalObject.PrintValues();

            AdvancedClass.PrintHowManyInstances();
            var advancedObject = new AdvancedClass();
            AdvancedClass.PrintHowManyInstances();

            advancedObject.PrintValues();
            var advancedCopy = (AdvancedClass)advancedObject.Clone();
            advancedCopy.PrintValues();

            advancedCopy.Dispose();
            advancedObject.Dispose();
        }
    }
}
