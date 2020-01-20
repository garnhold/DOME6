using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public abstract class DOMEVariableTypeConcept_Primitive_Simple : DOMEVariableTypeConcept_Primitive
    {
        private string default_construction_expression;

        public DOMEVariableTypeConcept_Primitive_Simple(DOMElement_GrammarDefinition g, string n, string c) : base(g, n)
        {
            default_construction_expression = c;
        }

        public override string GetDefaultConstructionExpression()
        {
            return default_construction_expression;
        }
    }
}