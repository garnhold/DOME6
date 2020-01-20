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
    public class DOMEClass_Generated_GrammarElement_Helper_Utilities : DOMEClass_Generated_GrammarElement_Helper
    {
        private OperationCache<string> get_type_name;

        public DOMEClass_Generated_GrammarElement_Helper_Utilities(DOMElement_GrammarDefinition g) : base(g)
        {
            get_type_name = new OperationCache<string>(delegate() {
                return GetGrammarDefinition().GetGrammarName() + "DOMinatorUtilities";
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
                "PARSER", GetGrammarDefinition().GetParserName(),
                "LEXER", GetGrammarDefinition().GetLexerName(),
                "SYNTAX_EXCEPTION_THROWER", GetGrammarDefinition().GetSyntaxExceptionThrower().GetTypeName()
            );

            code.Write("static public class ?TYPE", delegate() {
                code.Write("static public ?PARSER CreateParser(ICharStream stream)", delegate() {
                    code.Write("?PARSER parser = new ?PARSER(new CommonTokenStream(new ?LEXER(stream)));");

                    code.Write("parser.RemoveErrorListeners();");
                    code.Write("parser.AddErrorListener(?SYNTAX_EXCEPTION_THROWER.INSTANCE);");
                    code.Write("return parser;");
                });

                code.Write("static public ?PARSER CreateParser(Stream stream)", delegate() {
                    code.Write("return CreateParser(new AntlrInputStream(stream));");
                });

                code.Write("static public ?PARSER CreateParser(TextReader text_reader)", delegate() {
                    code.Write("return CreateParser(new AntlrInputStream(text_reader));");
                });

                code.Write("static public ?PARSER CreateParser(string text)", delegate() {
                    code.Write("return CreateParser(new StringReader(text));");
                });

                code.Write("static public ?PARSER CreateFileParser(string filename)", delegate() {
                    code.Write("return CreateParser(new AntlrFileStream(filename));");
                });
            });
        }
    }
}