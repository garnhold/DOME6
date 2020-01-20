using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public class DOMEVariableTypeConcept_Primitive_NewConstruct : DOMEVariableTypeConcept_Primitive
    {
        private OperationCache<string> get_default_construction_expression;

        public DOMEVariableTypeConcept_Primitive_NewConstruct(DOMElement_GrammarDefinition g, string n) : base(g, n)
        {
            get_default_construction_expression = new OperationCache<string>("get_default_construction_expression", delegate() {
                return GetStringToTypeExpression("");
            });
        }

        public override string GetDefaultConstructionExpression()
        {
            return get_default_construction_expression.Fetch();
        }

        public override string GetStringToTypeExpression(string string_expression)
        {
            return CSLine.Single("new ?TYPE(?STRING_EXPRESSION)",
                "TYPE", GetTypeName(),
                "STRING_EXPRESSION", string_expression
            );
        }
    }
}