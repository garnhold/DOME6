using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    static public class DOMEVariableTypeContextExtensions
    {
        static public DOMEVariableType Wrap(this DOMEVariableTypeConcept item, bool is_collection)
        {
            if (is_collection)
                return item.GetAsMultiple();

            return item.GetAsSingle();
        }
    }
}