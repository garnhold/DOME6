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
    public abstract class DOMEVariableType_Multiple_ICollection : DOMEVariableType_Multiple
    {
        protected override void GenerateVariableClearFunctionBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "VARIABLE", variable.GetVariableName()
            );

            code.Write("?VARIABLE.Clear();");
        }

        protected override void GenerateVariableAddFunctionBody(CSTextDocumentBuilder text, DOMEVariable variable, string input, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "VARIABLE", variable.GetVariableName(),
                "INPUT", input
            );

            code.Write("?VARIABLE.Add(?INPUT);");
        }

        protected override string GenerateVariableGetFunctionReturnContainerType(string type)
        {
            return CSLine.Single("IEnumerable<?TYPE>",
                "TYPE", type
            );
        }

        protected override string GenerateVariableGetFunctionBodyGetReturnExpression(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            return CSLine.Single("?VARIABLE",
                "VARIABLE", variable.GetVariableName()
            );
        }

        public DOMEVariableType_Multiple_ICollection(DOMEVariableTypeConcept t) : base(t) { }
    }
}