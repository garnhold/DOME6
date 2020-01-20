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
    public abstract class DOMEVariableType_Multiple_RuleDefinition_AutoParent : DOMEVariableType_Multiple_RuleDefinition
    {
        protected override void GenerateVariableConstructionInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "VARIABLE", variable.GetVariableName(),
                "TYPE", GetTypeName()
            );

            code.Write("?VARIABLE = new ?TYPE(this);");
        }

        public DOMEVariableType_Multiple_RuleDefinition_AutoParent(DOMEClass p, DOMEVariableTypeConcept t) : base(p, t) { }

        public override bool IsSingleParentEnforced()
        {
            return true;
        }
    }
}