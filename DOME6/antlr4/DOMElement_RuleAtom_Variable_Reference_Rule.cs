//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 4/5/2016 11:36:44 AM

using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public partial class DOMElement_RuleAtom_Variable_Reference_Rule : DOMElement_RuleAtom_Variable_Reference
    {
        public override DOMEContext GetVariableContext()
        {
            return GetReferencedRuleDefinition();
        }

        public override DOMEVariableTypeConcept GetDefaultVariableTypeInternal()
        {
            return GetReferencedRuleDefinition();
        }

        public DOMElement_RuleDefinition GetReferencedRuleDefinition()
        {
            return GetRuleReference().Resolve();
        }
    }
}