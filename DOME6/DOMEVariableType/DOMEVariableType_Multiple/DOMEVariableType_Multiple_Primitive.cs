using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public abstract class DOMEVariableType_Multiple_Primitive : DOMEVariableType_Multiple_ICollection
    {
        protected override void GenerateVariableDeclarationInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "VARIABLE", variable.GetVariableName()
            );

            code.Write("private ?TYPE ?VARIABLE;");
        }

        protected override void GenerateVariableConstructionInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "VARIABLE", variable.GetVariableName(),
                "TYPE", GetTypeName()
            );

            code.Write("?VARIABLE = new ?TYPE();");
        }

        protected override string GenerateVariableDuplicateExpression(string instance)
        {
            return instance;
        }

        public DOMEVariableType_Multiple_Primitive(DOMEVariableTypeConcept t) : base(t) { }
    }
}