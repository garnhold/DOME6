//-------------------------------
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
    public partial class DOMElement_RuleDefinition_Abstract : DOMElement_RuleDefinition
    {
        public override void GenerateMainClass(CSTextDocumentBuilder text)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "ACCESS", this.GetInfoValue("domify"),
                "BASE_TYPE", GetBaseType().GetTypeName(),
                "CONTEXT", GetContextName(),
                "RESOLVER", GetGrammarDefinition().GetResolver().GetTypeName()
            );

            code.Write("public abstract partial class ?TYPE : ?BASE_TYPE", delegate() {
                code.Write("public abstract ?TYPE Duplicate();");

                code.Write("static ?ACCESS ?TYPE DOMify(?CONTEXT context)", delegate() {
                    code.Write("return ?RESOLVER.Resolve<?TYPE>(context);");
                });
                GenerateBasicDOMifyFunctions(text, false);
            });
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