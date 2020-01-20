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
    public class DOMEClass_Generated_GrammarElement_Element_NoParent : DOMEClass_Generated_GrammarElement_Element
    {
        public DOMEClass_Generated_GrammarElement_Element_NoParent(DOMElement_GrammarDefinition g) : base(g)
        {
        }

        public override void GenerateMainClass(CSTextDocumentBuilder text)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "BASE_TYPE", GetBaseType().GetTypeName()
            );

            code.Write("public abstract partial class ?TYPE : ?BASE_TYPE, Relatable", delegate() {
                code.Write("public ?TYPE()", delegate() {
                    code.Write("OnConstruct();");
                });
                code.Write("partial void OnConstruct();");
            });
        }
    }
}