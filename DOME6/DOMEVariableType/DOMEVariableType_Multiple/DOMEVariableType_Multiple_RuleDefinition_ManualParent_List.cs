﻿using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public class DOMEVariableType_Multiple_RuleDefinition_ManualParent_List : DOMEVariableType_Multiple_RuleDefinition_ManualParent
    {
        private OperationCache<string> get_type_name;

        public DOMEVariableType_Multiple_RuleDefinition_ManualParent_List(DOMEClass p, DOMEVariableTypeConcept t) : base(p, t)
        {
            get_type_name = new OperationCache<string>("get_type_name", delegate() {
                return CSLine.Single("List<?INNER_TYPE>",
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