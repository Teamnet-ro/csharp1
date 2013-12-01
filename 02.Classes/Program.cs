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
        }
    }
}
