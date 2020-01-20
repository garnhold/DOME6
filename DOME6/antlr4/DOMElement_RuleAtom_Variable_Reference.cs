using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace DOME
{
    public abstract class DOMElement_RuleAtom_Variable_Reference : DOMElement_RuleAtom_Variable, HasQuantifier
    {
        private OperationCache<DOMEVariableTypeConcept> get_default_variable_type_context;

        public abstract DOMElement_Quantifier GetQuantifier();
        public abstract DOMEVariableTypeConcept GetDefaultVariableTypeInternal();

        public DOMElement_RuleAtom_Variable_Reference()
        {
            get_default_variable_type_context = new OperationCache<DOMEVariableTypeConcept>(delegate() {
                DOMEVariableTypeConcept type = GetDefaultVariableTypeInternal();
                HasInfo has_info = type as HasInfo;

                if (has_info != null)
                {
                    return has_info.ConvertInfoValue<DOMEVariableTypeConcept>("type",
                        () => type,
                        s => GetGrammarDefinition().GetTypeConcept(s)
                    );
                }

                return type;
            });
        }

        public override bool IsVariableCollection()
        {
            if (this.IsQuantifierEffectivelyMultiple())
                return true;

            return false;
        }

        public override DOMEVariableTypeConcept GetDefaultVariableTypeContext()
        {
            return get_default_variable_type_context.Fetch();
        }
    }
}