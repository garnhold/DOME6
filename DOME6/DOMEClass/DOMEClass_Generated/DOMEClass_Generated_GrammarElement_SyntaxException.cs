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
    public class DOMEClass_Generated_GrammarElement_SyntaxException : DOMEClass_Generated_GrammarElement
    {
        private OperationCache<string> get_type_name;
        private OperationCache<DOMEClass> get_base_type;

        public DOMEClass_Generated_GrammarElement_SyntaxException(DOMElement_GrammarDefinition g) : base(g)
        {
            get_type_name = new OperationCache<string>(delegate() {
                return GetGrammarDefinition().GetGrammarName() + "SyntaxException";
            });

            get_base_type = new OperationCache<DOMEClass>(delegate() {
                return GetGrammarDefinition()
                    .GetClassGeneric(
                        GetGrammarDefinition().GetSettings().GetExceptionBaseTypeName()
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

        public override void GenerateMainClass(CSTextDocumentBuilder text)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "BASE_TYPE", GetBaseType().GetTypeName()
            );

            code.Write("public partial class ?TYPE : ?BASE_TYPE", delegate() {
                code.Write("private int line;");
                code.Write("private int column;");
                code.Write("private string base_message;");

                code.Write("public ?TYPE(int l, int c, string m) : base()", delegate() {
                    code.Write("line = l;");
                    code.Write("column = c;");
                    code.Write("base_message = m;");
                });

                code.Write("public int GetLine()", delegate() {
                    code.Write("return line;");
                });

                code.Write("public int GetColumn()", delegate() {
                    code.Write("return column;");
                });

                code.Write("public string GetBaseMessage()", delegate() {
                    code.Write("return base_message;");
                });

                code.Write("public string GetMessage()", delegate() {
                    code.Write("return \"(\" + line + \", \" + column + \")\" +  base_message;");
                });
            });
        }

        public override bool GenerateStubClass(CSTextDocumentBuilder text)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "BASE_TYPE", GetBaseType().GetTypeName()
            );

            code.Write("public partial class ?TYPE : ?BASE_TYPE", delegate() {
            });

            return true;
        }
    }
}