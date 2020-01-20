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
    public class DOMEVariableType_Multiple_RuleDefinition_NoParent_LabeledItemSet : DOMEVariableType_Multiple_RuleDefinition_NoParent
    {
        private DOMEVariableTypeConcept label_type_concept;

        private OperationCache<string> get_type_name;

        protected override string GenerateVariableGetFunctionReturnContainerType(string type)
        {
            return CSLine.Single("EnumerableLookupSet<?LABEL_TYPE, ?TYPE>",
                "LABEL_TYPE", GetLabelTypeConcept().GetStoreTypeName(),
                "TYPE", type
            );
        }

        public DOMEVariableType_Multiple_RuleDefinition_NoParent_LabeledItemSet(DOMEClass p, DOMEVariableTypeConcept t, DOMEVariableTypeConcept l) : base(p, t)
        {
            label_type_concept = l;

            get_type_name = new OperationCache<string>("get_type_name", delegate() {
                return CSLine.Single("LabeledItemSet<?LABEL_TYPE, ?INNER_TYPE>",
                    "LABEL_TYPE", GetLabelTypeConcept().GetStoreTypeName(),
                    "INNER_TYPE", GetTypeConcept().GetStoreTypeName()
                );
            });
        }
        
        public override string GetTypeName()
        {
            return get_type_name.Fetch();
        }

        public DOMEVariableTypeConcept GetLabelTypeConcept()
        {
            return label_type_concept;
        }
    }
}