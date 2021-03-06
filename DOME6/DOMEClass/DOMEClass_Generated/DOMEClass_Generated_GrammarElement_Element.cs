﻿using System;
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
    public abstract class DOMEClass_Generated_GrammarElement_Element : DOMEClass_Generated_GrammarElement
    {
        private OperationCache<string> get_type_name;
        private OperationCache<DOMEClass> get_base_type;

        public DOMEClass_Generated_GrammarElement_Element(DOMElement_GrammarDefinition g) : base(g)
        {
            get_type_name = new OperationCache<string>("get_type_name", delegate() {
                return GetGrammarDefinition().GetSettings().GetElementName();
            });

            get_base_type = new OperationCache<DOMEClass>("get_base_type", delegate() {
                return GetGrammarDefinition()
                    .GetClassGeneric(
                        GetGrammarDefinition().GetSettings().GetElementBaseTypeName()
                    );
            });
        }
        
        public override string GetTypeName()
        {
            return get_type_name.Fetch();
        }

        
        public override DOMEClass GetBaseType()
        {
            return get_base_type.Fetch();
        }

        public override bool GenerateStubClass(CSTextDocumentBuilder text)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "BASE_TYPE", GetBaseType().GetTypeName()
            );

            code.Write("public abstract partial class ?TYPE : ?BASE_TYPE", delegate() {
            });

            return true;
        }
    }
}