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
    public class DOMEVariableType_Single_RuleDefinition_ManualParent : DOMEVariableType_Single_RuleDefinition
    {
        protected override void GenerateVariableConstructionInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "VARIABLE", variable.GetVariableName(),
                "EXPRESSION", GetTypeConcept().GetDefaultConstructionExpression()
            );

            code.Write("?VARIABLE = ?EXPRESSION;");
        }

        protected override void GenerateVariableSetFunctionBody(CSTextDocumentBuilder text, DOMEVariable variable, string input, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "VARIABLE", variable.GetVariableName(),
                "INPUT", input
            );

            code.Write("?VARIABLE = ?INPUT;");
            code.Write("if(?VARIABLE != null)", delegate() {
                code.Write("?VARIABLE.SetParent(this);");
            }, false);
        }

        protected override string GenerateVariableGetFunctionBodyGetReturnExpression(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            return CSLine.Single("?VARIABLE",
                "VARIABLE", variable.GetVariableName()
            );
        }

        public DOMEVariableType_Single_RuleDefinition_ManualParent(DOMEClass p, DOMEVariableTypeConcept t) : base(p, t) { }

        public override string GetTypeName()
        {
            return GetTypeConcept().GetStoreTypeName();
        }
    }
}