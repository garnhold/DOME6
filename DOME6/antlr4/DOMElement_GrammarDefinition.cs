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
    public partial class DOMElement_GrammarDefinition : DOMElement
    {
        private DOMESettings settings;

        [RelatableChild]
        private DOMEClass_Generated_GrammarElement_Element element;

        [RelatableChild]
        private DOMEClass_Generated_GrammarElement_Helper_Utilities utilities;
        [RelatableChild]
        private DOMEClass_Generated_GrammarElement_Helper_IParseTreeExtensions iparse_tree_extensions;
        [RelatableChild]
        private DOMEClass_Generated_GrammarElement_Helper_Resolver resolver;

        [RelatableChild]
        private DOMEClass_Generated_GrammarElement_SyntaxException syntax_exception;
        [RelatableChild]
        private DOMEClass_Generated_GrammarElement_Helper_SyntaxExceptionThrower syntax_exception_thrower;

        private OperationCache<string> get_parser_name;
        private OperationCache<string> get_lexer_name;
        private OperationCache<string> get_visitor_name;
        private OperationCache<string> get_main_filename;

        private OperationCache<DOMEClass_Generic, string> get_class_generic;
        private OperationCache<DOMEVariableTypeConcept, string> get_type_concept;

        static public void GenerateDOM(DOMESettings settings)
        {
            DOMElement_GrammarDefinition.DOMifyGrammar(settings.GetGrammarName()).Generate(settings);
        }

        static public DOMElement_GrammarDefinition DOMifyGrammar(string grammar_name)
        {
            return DOMElement_GrammarDefinition.DOMifyFile(grammar_name + ".g4");
        }

        private void OnSetImportHeader(DOMElement_ImportHeader input)
        {
            if (input != null)
            {
                IEnumerable<DOMElement_GrammarDefinition> grammars = input.GetGrammarNames()
                    .Convert(n => DOMifyGrammar(n));

                grammars.Convert(g => g.GetDefinitions()).ProcessCopy(d => AddDefinition(d));
            }
        }

        private void GenerateMainFile()
        {
            CSTextDocument document = new CSTextDocument();
            CSTextDocumentBuilder text = document.CreateCSTextBuilder();
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "NAMESPACE", settings.GetNamespaceName()
            );

            code.Write("using System;");
            code.Write("using System.IO;");
            code.Write("using System.Collections;");
            code.Write("using System.Collections.Generic;");
            code.SkipLine();

            code.Write("using Crunchy.Dough;");
            code.Write("using Crunchy.Salt;");
            code.Write("using Crunchy.Noodle;");
            code.SkipLine();

            code.Write("using Antlr4.Runtime;");
            code.Write("using Antlr4.Runtime.Tree;");
            code.SkipLine();

            code.Write("namespace ?NAMESPACE", delegate() {
                this.GetDeepChildren<DOMEClass_Generated>().Process(g => g.GenerateMainClass(text));
            });

            document.RenderDocument().Save(settings.GetOutputDirectory(), GetMainFilename(), true);
        }

        private void GenerateStubClasses()
        {
            foreach (DOMEClass_Generated @class in this.GetDeepChildren<DOMEClass_Generated>())
            {
                CSTextDocument document = new CSTextDocument();
                CSTextDocumentBuilder text = document.CreateCSTextBuilder();
                CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                    "NAMESPACE", settings.GetNamespaceName()
                );

                code.Write("using System;");
                code.Write("using System.Collections;");
                code.Write("using System.Collections.Generic;");
                code.SkipLine();

                code.Write("using Crunchy.Dough;");
                code.Write("using Crunchy.Salt;");
                code.Write("using Crunchy.Noodle;");
                code.SkipLine();

                if (code.Write("namespace ?NAMESPACE", delegate() {
                    return @class.GenerateStubClass(text);
                }))
                {
                    document.RenderDocument().SaveClass(settings.GetOutputDirectory(), @class.GetTypeName(), false);
                }
            }
        }

        partial void OnConstructor()
        {
            utilities = new DOMEClass_Generated_GrammarElement_Helper_Utilities(this);
            iparse_tree_extensions = new DOMEClass_Generated_GrammarElement_Helper_IParseTreeExtensions(this);
            resolver = new DOMEClass_Generated_GrammarElement_Helper_Resolver(this);

            syntax_exception = new DOMEClass_Generated_GrammarElement_SyntaxException(this);
            syntax_exception_thrower = new DOMEClass_Generated_GrammarElement_Helper_SyntaxExceptionThrower(this);

            get_parser_name = new OperationCache<string>(delegate() {
                return GetGrammarName() + "Parser";
            });

            get_lexer_name = new OperationCache<string>(delegate() {
                return GetGrammarName() + "Lexer";
            });

            get_visitor_name = new OperationCache<string>(delegate() {
                return GetGrammarName() + "BaseVisitor";
            });

            get_main_filename = new OperationCache<string>(delegate() {
                return GetGrammarName() + "DOMinator.cs";
            });

            get_class_generic = new OperationCache<DOMEClass_Generic, string>(delegate(string name) {
                return new DOMEClass_Generic(this, name);
            });

            get_type_concept = new OperationCache<DOMEVariableTypeConcept, string>(delegate(string name) {
                return Types.GetFilteredTypes(
                    Filterer_Type.CanBeTreatedAs<DOMEVariableTypeConcept>(),
                    Filterer_Type.HasCustomLabeledAttributeOfType<DOMEVariableTypeConceptAttribute>(name, true)
                ).GetFirst().IfNotNull(t => t.CreateInstance<DOMEVariableTypeConcept>(this), delegate() {
                    if (name.TryTrimPrefix("enum_", out name))
                        return new DOMEVariableTypeConcept_Primitive_Enum(this, name);

                    return new DOMEVariableTypeConcept_Primitive_NewConstruct(this, name);
                });
            });
        }

        public void Generate(DOMESettings s)
        {
            settings = s;
            element = settings.GetVariableTypeCreator().GetElementFactory().Create(this);

            GenerateMainFile();
            if (settings.ShouldGenerateStubClasses())
                GenerateStubClasses();
        }

        public string GetGrammarName()
        {
            return GetGrammarHeader().GetGrammarName();
        }

        public string GetParserName()
        {
            return get_parser_name.Fetch();
        }

        public string GetLexerName()
        {
            return get_lexer_name.Fetch();
        }

        public string GetVisitorName()
        {
            return get_visitor_name.Fetch();
        }

        public string GetMainFilename()
        {
            return get_main_filename.Fetch();
        }

        public DOMEClass_Generic GetClassGeneric(string name)
        {
            return get_class_generic.Fetch(name);
        }

        public DOMEVariableTypeConcept GetTypeConcept(string name)
        {
            return get_type_concept.Fetch(name);
        }

        public DOMESettings GetSettings()
        {
            return settings;
        }

        public DOMEClass_Generated_GrammarElement_Element GetElement()
        {
            return element;
        }

        public DOMEClass_Generated_GrammarElement_Helper_Utilities GetUtilities()
        {
            return utilities;
        }

        public DOMEClass_Generated_GrammarElement_Helper_IParseTreeExtensions GetIParseTreeExtensions()
        {
            return iparse_tree_extensions;
        }

        public DOMEClass_Generated_GrammarElement_Helper_Resolver GetResolver()
        {
            return resolver;
        }

        public DOMEClass_Generated_GrammarElement_SyntaxException GetSyntaxException()
        {
            return syntax_exception;
        }

        public DOMEClass_Generated_GrammarElement_Helper_SyntaxExceptionThrower GetSyntaxExceptionThrower()
        {
            return syntax_exception_thrower;
        }
    }
}