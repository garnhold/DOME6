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
    public class DOMEClass_Generated_GrammarElement_Helper_Resolver : DOMEClass_Generated_GrammarElement_Helper
    {
        private OperationCache<string> get_type_name;

        public DOMEClass_Generated_GrammarElement_Helper_Resolver(DOMElement_GrammarDefinition g) : base(g)
        {
            get_type_name = new OperationCache<string>(delegate() {
                return GetGrammarDefinition().GetGrammarName() + "Resolver";
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
                "VISITOR", GetGrammarDefinition().GetVisitorName(),
                "ELEMENT", GetGrammarDefinition().GetElement().GetTypeName()
            );

            code.Write("public partial class ?TYPE : ?VISITOR<?ELEMENT>", delegate() {
                code.Write("static private ?TYPE instance;");
                code.Write("static public ?TYPE GetInstance()", delegate() {
                    code.Write("if(instance == null)", delegate() {
                        code.Write("instance = new ?TYPE();");
                    }, false);

                    code.Write("return instance;");
                });

                code.Write("static public ?ELEMENT Resolve(IParseTree parse_tree)", delegate() {
                    code.Write("if(parse_tree != null)", delegate() {
                        code.Write("return GetInstance().Visit(parse_tree);");
                    }, false);

                    code.Write("return null;");
                });

                code.Write("static public T Resolve<T>(IParseTree parse_tree) where T : ?ELEMENT", delegate() {
                    code.Write("return Resolve(parse_tree) as T;");
                });

                code.Write("private ?TYPE()", delegate() {
                });

                GetGrammarDefinition().GetDeepChildren<DOMEVisitTarget>().Process(g => g.GenerateVisitFunction(text));
            });
        }

        public override bool GenerateStubClass(CSTextDocumentBuilder text)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "VISITOR", GetGrammarDefinition().GetVisitorName(),
                "ELEMENT", GetGrammarDefinition().GetElement().GetTypeName()
            );

            code.Write("public partial class ?TYPE : ?VISITOR<?ELEMENT>", delegate() {
            });

            return true;
        }
    }
}