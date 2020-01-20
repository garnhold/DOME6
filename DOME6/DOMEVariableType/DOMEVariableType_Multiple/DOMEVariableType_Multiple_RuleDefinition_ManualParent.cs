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
    public abstract class DOMEVariableType_Multiple_RuleDefinition_ManualParent : DOMEVariableType_Multiple_RuleDefinition
    {
        protected override void GenerateVariableConstructionInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "VARIABLE", variable.GetVariableName(),
                "TYPE", GetTypeName()
            );

            code.Write("?VARIABLE = new ?TYPE();");
        }

        protected override void GenerateVariableAddFunctionBody(CSTextDocumentBuilder text, DOMEVariable variable, string input, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "VARIABLE", variable.GetVariableName(),
                "INPUT", input
            );

            code.Write("?VARIABLE.Add(?INPUT);");
            code.Write("if(?INPUT != null)", delegate() {
                code.Write("?INPUT.SetParent(this);");
            }, false);
        }

        public DOMEVariableType_Multiple_RuleDefinition_ManualParent(DOMEClass p, DOMEVariableTypeConcept t) : base(p, t) { }
    }
}