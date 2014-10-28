using System.Collections.Generic;

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
    }
}
