﻿//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 4/5/2016 10:26:38 AM

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
    public partial class DOMElement_RuleDefinition_Concrete_Inherited : DOMElement_RuleDefinition_Concrete
    {
        protected override void GenerateMainClassAdditionalStaticFunctions(CSTextDocumentBuilder text)
        {
            GenerateBasicDOMifyFunctions(text, true);
        }

        protected override void GenerateMainClassDuplicateFunction(CSTextDocumentBuilder text)
        {
            GenerateBasicDuplicateFunction(text, true, GetDefaultBaseType().GetTypeName());
        }

        protected override DOMEClass GetDefaultBaseType()
        {
            return this.GetParent<DOMEClass>();
        }

        public override string GetGetContextFunctionName()
        {
            return this.GetParent<DOMEContext>().GetGetContextFunctionName();
        }
    }
}