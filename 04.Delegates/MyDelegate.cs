using System;

namespace Delegates
{
    // nu pot moșteni direct din Delegate
    //internal class MyDelegate : Delegate{}

    // nu pot moșteni direct din MulticastDelegate
    //internal class MyDelegate : MulticastDelegate{}

    public delegate void MyDelegate(string s);

    delegate int MyNonVoidDelegate(string s);

    delegate T MyGenericDelegate<T>(T input);
}
