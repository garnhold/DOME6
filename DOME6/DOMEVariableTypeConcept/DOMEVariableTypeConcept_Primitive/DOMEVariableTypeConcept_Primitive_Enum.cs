using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public class DOMEVariableTypeConcept_Primitive_Enum : DOMEVariableTypeConcept_Primitive
    {
        public DOMEVariableTypeConcept_Primitive_Enum(DOMElement_GrammarDefinition g, string n) : base(g, n)
        {
        }

        public override string GetDefaultConstructionExpression()
        {
            return CSLine.Single("default(?TYPE)",
                "TYPE", GetTypeName().StyleAsFunctionName()
            );
        }

        public override string GetStringToTypeExpression(string string_expression)
        {
            return CSLine.Single("?STRING_EXPRESSION.ParseEnum<?TYPE>()",
                "STRING_EXPRESSION", string_expression,
                "TYPE", GetTypeName().StyleAsFunctionName()
            );
        }
    }
}