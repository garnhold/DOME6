using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public interface DOMEVariableTypeConcept
    {
        string GetTypeName();
        string GetStoreTypeName();
        string GetRetrieveTypeName();

        string GetDefaultConstructionExpression();
        string GetContextToTypeExpression(string context_expression);

        DOMEVariableType GetAsSingle();
        DOMEVariableType GetAsMultiple();
    }
}