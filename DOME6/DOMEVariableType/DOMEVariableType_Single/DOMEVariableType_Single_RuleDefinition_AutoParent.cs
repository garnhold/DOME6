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
    public class DOMEVariableType_Single_RuleDefinition_AutoParent : DOMEVariableType_Single_RuleDefinition
    {
        private OperationCache<string> get_type_name;

        protected override void GenerateVariableConstructionInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "VARIABLE", variable.GetVariableName(),
                "TYPE", GetTypeName()
            );

            code.Write("?VARIABLE = new ?TYPE(this);");
        }

        protected override void GenerateVariableSetFunctionBody(CSTextDocumentBuilder text, DOMEVariable variable, string input, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "VARIABLE", variable.GetVariableName(),
                "INPUT", input
            );

            code.Write("?VARIABLE.Set(?INPUT);");
        }

        protected override string GenerateVariableGetFunctionBodyGetReturnExpression(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            return CSLine.Single("?VARIABLE.Get()",
                "VARIABLE", variable.GetVariableName()
            );
        }

        public DOMEVariableType_Single_RuleDefinition_AutoParent(DOMEClass p, DOMEVariableTypeConcept t) : base(p, t)
        {
            get_type_name = new OperationCache<string>("get_type_name", delegate() {
                return CSLine.Single("HoldingSingle<?PARENT_TYPE, ?INNER_TYPE>",
                    "PARENT_TYPE", GetParentType().GetTypeName(),
                    "INNER_TYPE", GetTypeConcept().GetStoreTypeName()
                );
            });
        }

        public override string GetTypeName()
        {
            return get_type_name.Fetch();
        }
    }
}