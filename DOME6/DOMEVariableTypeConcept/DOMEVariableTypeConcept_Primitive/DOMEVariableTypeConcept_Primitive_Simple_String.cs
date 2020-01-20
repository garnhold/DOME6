using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    [DOMEVariableTypeConcept("string")]
    public class DOMEVariableTypeConcept_Primitive_Simple_String : DOMEVariableTypeConcept_Primitive_Simple
    {
        public DOMEVariableTypeConcept_Primitive_Simple_String(DOMElement_GrammarDefinition g) : base(g, "string", "\"\"")
        {
        }

        public override string GetStringToTypeExpression(string string_expression)
        {
            return string_expression;
        }
    }
}