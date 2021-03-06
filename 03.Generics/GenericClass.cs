﻿using System;
using System.ComponentModel;

namespace Generics
{
    // type parameter definit de clasă e disponibil peste tot
    class GenericClass<T>
    {
        private readonly T value;

        public void SomeMethod()
        {
            Console.WriteLine(value);
        }

        // metodele pot introduce type parameters noi
        public void MoreGenericMethod<TOther>(
            T aValue,
            TOther otherValue)
        {
            Console.WriteLine(
                "{0} și {1}",
                aValue,
                otherValue);
        }

        public GenericClass(T value)
        {
            this.value = value;
        }
    }

    // this is a different class from GenericClass, it just happens to have
    // the same name.
    static class GenericClass
    {
        internal static GenericClass<T> Create<T>(T value)
        {
            return new GenericClass<T>(value);
        }
    }
}
