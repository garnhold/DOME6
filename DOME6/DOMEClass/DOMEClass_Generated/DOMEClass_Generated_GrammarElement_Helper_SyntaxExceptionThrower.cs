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
    public class DOMEClass_Generated_GrammarElement_Helper_SyntaxExceptionThrower : DOMEClass_Generated_GrammarElement_Helper
    {
        private OperationCache<string> get_type_name;

        public DOMEClass_Generated_GrammarElement_Helper_SyntaxExceptionThrower(DOMElement_GrammarDefinition g) : base(g)
        {
            get_type_name = new OperationCache<string>("get_type_name", delegate() {
                return GetGrammarDefinition().GetGrammarName() + "SyntaxExceptionThrower";
            });
        }
        
        public override string GetTypeName()
        {
            return get_type_name.Fetch();
        }

        public override void GenerateMainClass(CSTextDocumentBuilder text)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "EXCEPTION", GetGrammarDefinition().GetSyntaxException().GetTypeName()
            );

            code.Write("public class ?TYPE : BaseErrorListener", delegate() {
                code.Write("static public readonly ?TYPE INSTANCE = new ?TYPE();");

                code.Write("private ?TYPE()", delegate() {
                });

                code.Write("public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)", delegate() {
                    code.Write("throw new ?EXCEPTION(line, msg);");
                });
            });
        }
    }
}