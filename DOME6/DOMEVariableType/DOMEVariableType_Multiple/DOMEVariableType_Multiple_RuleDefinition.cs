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
    public abstract class DOMEVariableType_Multiple_RuleDefinition : DOMEVariableType_Multiple_ICollection
    {
        private DOMEClass parent_type;

        protected override void GenerateVariableDeclarationInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "VARIABLE", variable.GetVariableName()
            );

            code.Write("[RelatableChild]private ?TYPE ?VARIABLE;");
        }

        protected override string GenerateVariableDuplicateExpression(string instance)
        {
            return CSLine.Single("?INSTANCE.Convert(i => i.IfNotNull(z => z.Duplicate()))",
                "INSTANCE", instance
            );
        }

        public DOMEVariableType_Multiple_RuleDefinition(DOMEClass p, DOMEVariableTypeConcept t) : base(t)
        {
            parent_type = p;
        }

        public DOMEClass GetParentType()
        {
            return parent_type;
        }
    }
}