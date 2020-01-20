using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    [DOMEVariableTypeConcept("bool")]
    public class DOMEVariableTypeConcept_Primitive_Simple_Parseable_Bool : DOMEVariableTypeConcept_Primitive_Simple_Parseable
    { public DOMEVariableTypeConcept_Primitive_Simple_Parseable_Bool(DOMElement_GrammarDefinition g) : base(g, "bool", "false") { } }

    [DOMEVariableTypeConcept("byte")]
    public class DOMEVariableTypeConcept_Primitive_Simple_Parseable_Byte : DOMEVariableTypeConcept_Primitive_Simple_Parseable
    { public DOMEVariableTypeConcept_Primitive_Simple_Parseable_Byte(DOMElement_GrammarDefinition g) : base(g, "byte", "0") { } }

    [DOMEVariableTypeConcept("short")]
    public class DOMEVariableTypeConcept_Primitive_Simple_Parseable_Short : DOMEVariableTypeConcept_Primitive_Simple_Parseable
    { public DOMEVariableTypeConcept_Primitive_Simple_Parseable_Short(DOMElement_GrammarDefinition g) : base(g, "short", "0") { } }

    [DOMEVariableTypeConcept("int")]
    public class DOMEVariableTypeConcept_Primitive_Simple_Parseable_Int : DOMEVariableTypeConcept_Primitive_Simple_Parseable
    { public DOMEVariableTypeConcept_Primitive_Simple_Parseable_Int(DOMElement_GrammarDefinition g) : base(g, "int", "0") { } }

    [DOMEVariableTypeConcept("long")]
    public class DOMEVariableTypeConcept_Primitive_Simple_Parseable_Long : DOMEVariableTypeConcept_Primitive_Simple_Parseable
    { public DOMEVariableTypeConcept_Primitive_Simple_Parseable_Long(DOMElement_GrammarDefinition g) : base(g, "long", "0") { } }

    [DOMEVariableTypeConcept("float")]
    public class DOMEVariableTypeConcept_Primitive_Simple_Parseable_Float : DOMEVariableTypeConcept_Primitive_Simple_Parseable
    { public DOMEVariableTypeConcept_Primitive_Simple_Parseable_Float(DOMElement_GrammarDefinition g) : base(g, "float", "0.0f") { } }

    [DOMEVariableTypeConcept("double")]
    public class DOMEVariableTypeConcept_Primitive_Simple_Parseable_Double : DOMEVariableTypeConcept_Primitive_Simple_Parseable
    { public DOMEVariableTypeConcept_Primitive_Simple_Parseable_Double(DOMElement_GrammarDefinition g) : base(g, "double", "0.0") { } }

    [DOMEVariableTypeConcept("decimal")]
    public class DOMEVariableTypeConcept_Primitive_Simple_Parseable_Decimal : DOMEVariableTypeConcept_Primitive_Simple_Parseable
    { public DOMEVariableTypeConcept_Primitive_Simple_Parseable_Decimal(DOMElement_GrammarDefinition g) : base(g, "decimal", "0.0m") { } }

    public abstract class DOMEVariableTypeConcept_Primitive_Simple_Parseable : DOMEVariableTypeConcept_Primitive_Simple
    {
        public DOMEVariableTypeConcept_Primitive_Simple_Parseable(DOMElement_GrammarDefinition g, string n, string c) : base(g, n, c)
        {
        }

        public override string GetStringToTypeExpression(string string_expression)
        {
            return CSLine.Single("?STRING_EXPRESSION.Parse?TYPE()",
                "STRING_EXPRESSION", string_expression,
                "TYPE", GetTypeName().StyleAsFunctionName()
            );
        }
    }
}