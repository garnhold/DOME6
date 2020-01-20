//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 4/5/2016 11:32:37 AM

using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public partial class DOMElement_RuleAtom_Variable_InfoGroup : DOMElement_RuleAtom_Variable
    {
        private OperationCache<DOMEContext> get_variable_context;
        private OperationCache<DOMEVariableTypeConcept> get_default_variable_type_context;

        partial void OnConstructor()
        {
            get_variable_context = new OperationCache<DOMEContext>("get_variable_context", delegate() {
                DOMEContext variable_context;

                if(this.GetTopicalChildren<DOMElement_RuleAtom_Variable>()
                    .Convert(v => v.GetVariableContext())
                    .AreAllSame(out variable_context))
                    return variable_context;

                return null;
            });

            get_default_variable_type_context = new OperationCache<DOMEVariableTypeConcept>("get_default_variable_type_context", delegate() {
                DOMEVariableTypeConcept variable_type;

                if (this.GetTopicalChildren<DOMElement_RuleAtom_Variable>()
                    .Convert(v => v.GetVariableTypeConcept())
                    .AreAllSame(out variable_type))
                    return variable_type;

                return null;
            });
        }

        public override bool IsVariableCollection()
        {
            return true;
        }

        public override DOMEContext GetVariableContext()
        {
            return get_variable_context.Fetch();
        }

        public override DOMEVariableTypeConcept GetDefaultVariableTypeContext()
        {
            return get_default_variable_type_context.Fetch();
        }
    }
}