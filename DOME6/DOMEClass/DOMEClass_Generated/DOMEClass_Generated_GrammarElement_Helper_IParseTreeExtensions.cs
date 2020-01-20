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
    public class DOMEClass_Generated_GrammarElement_Helper_IParseTreeExtensions : DOMEClass_Generated_GrammarElement_Helper
    {
        private OperationCache<string> get_type_name;

        public DOMEClass_Generated_GrammarElement_Helper_IParseTreeExtensions(DOMElement_GrammarDefinition g) : base(g)
        {
            get_type_name = new OperationCache<string>(delegate() {
                return GetGrammarDefinition().GetGrammarName() + "IParseTreeExtensions";
            });
        }
        
        public override string GetTypeName()
        {
            return get_type_name.Fetch();
        }

        public override void GenerateMainClass(CSTextDocumentBuilder text)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName()
            );

            code.Write("static public class ?TYPE", delegate() {
                code.Write("static public string GetTextEX(this IParseTree item)", delegate() {
                    code.Write("if(item != null)", delegate() {
                        code.Write("return item.GetText();");
                    }, false);

                    code.Write("return \"\";");
                });
            });
        }
    }
}