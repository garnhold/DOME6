using System;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public interface HasQuantifier : Relatable
    {
        DOMElement_Quantifier GetQuantifier();
    }

    static public class HasQuantifierExtensions
    {
        static public bool IsQuantifierMultiple(this HasQuantifier item)
        {
            DOMElement_Quantifier quantifier = item.GetQuantifier();

            if (quantifier != null)
            {
                if (quantifier.IsQuantifierMultiple())
                    return true;
            }

            return false;
        }

        static public bool IsQuantifierEffectivelyMultiple(this HasQuantifier item)
        {
            if (item.GetSelfAndParents<HasQuantifier>().Has(p => p.IsQuantifierMultiple()))
                return true;

            return false;
        }
    }
}