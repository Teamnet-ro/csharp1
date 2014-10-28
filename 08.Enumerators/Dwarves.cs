using System.Collections.Generic;
using System.Numerics;

namespace _08.Enumerators
{
    class Collections
    {
        internal IEnumerable<string> TheSevenDwarves()
        {
            yield return "Doc";
            yield return "Mutulică";
            yield return "Morocănosul";
            yield return "Hapciu";
            yield return "Somnorosul";
            yield return "Rușinosul";
        }

        internal IEnumerable<BigInteger> Fibonacci()
        {
            BigInteger a = 0, b = 1;
            while (true)
            {
                yield return a;
                yield return b;
                a = a + b;
                b = a + b;
            }
        }

        internal IEnumerable<T> FirstTwelve<T>(IEnumerable<T> enumerable)
        {
            var count = 0;
            using (var enumerator = enumerable.GetEnumerator())
            {
                while (enumerator.MoveNext() && count < 12)
                {
                    yield return enumerator.Current;
                    count = count + 1;
                }
            }
        }

        // TODO: check numbers for null
        internal IEnumerable<BigInteger> OnlyEven(IEnumerable<BigInteger> numbers)
        {
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}
