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
    public abstract class DOMElement_RuleDefinition : DOMElement, DOMEClass_Generated, DOMEContext, DOMEVariableTypeConcept, HasInfo
    {
        private OperationCache<string> get_type_name;
        private OperationCache<string> get_store_type_name;
        private OperationCache<string> get_retrieve_type_name;

        private OperationCache<DOMEVariableType> get_as_single;
        private OperationCache<DOMEVariableType> get_as_multiple;
        private OperationCache<DOMEClass> get_base_type;

        private OperationCache<string> get_context_name;
        private OperationCache<string> get_context_default_variable_name;

        private OperationCache<LookupBackedSet<string, string>> get_info_settings;

        protected virtual DOMEClass GetDefaultBaseType() { return GetGrammarDefinition().GetElement(); }

        public abstract string GetRuleId();
        public abstract DOMElement_Configuration_Info GetInfo();

        public abstract void GenerateMainClass(CSTextDocumentBuilder text);
        public abstract bool GenerateStubClass(CSTextDocumentBuilder text);

        public virtual string GetGetContextFunctionName() { return GetContextId(); }

        static private LookupSet<string, string> DEFAULT_INFO_VALUES = new SettingTable(
            KeyValuePair.New("name", "default"),
            KeyValuePair.New("default_name", "default"),

            KeyValuePair.New("constructor", "public"),
            KeyValuePair.New("domify", "public"),

            KeyValuePair.New("base_type", "default"),
            KeyValuePair.New("store_type", "default"),
            KeyValuePair.New("retrieve_type", "default"),
            KeyValuePair.New("multiple_type", "list"),
            
            KeyValuePair.New("hook_load_context", "false"),
            KeyValuePair.New("store_text", "false"),

            KeyValuePair.New("type", "default"),
            KeyValuePair.New("manual", "false"),

            KeyValuePair.New("label_type", "string")
        );

        protected void GenerateBasicDOMifyFunctions(CSTextDocumentBuilder text, bool use_new)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "USE_NEW", use_new.ConvertBool("new"),
                "ACCESS", this.GetInfoValue("domify"),
                "TYPE", GetTypeName(),
                "UTILITIES", GetGrammarDefinition().GetUtilities().GetTypeName(),
                "CONTEXT", GetContextName(),
                "GET_CONTEXT_FUNCTION", GetGetContextFunctionName()
            );

            code.Write("static ?USE_NEW ?ACCESS ?TYPE DOMify(IParseTree parse_tree)", delegate() {
                code.Write("return DOMify(parse_tree as ?CONTEXT);");
            });

            code.Write("static ?USE_NEW ?ACCESS ?TYPE DOMify(Stream stream)", delegate() {
                code.Write("return DOMify(?UTILITIES.CreateParser(stream).?GET_CONTEXT_FUNCTION());");
            });

            code.Write("static ?USE_NEW ?ACCESS ?TYPE DOMify(string text)", delegate() {
                code.Write("return DOMify(?UTILITIES.CreateParser(text).?GET_CONTEXT_FUNCTION());");
            });

            code.Write("static ?USE_NEW ?ACCESS ?TYPE DOMifyFile(string filename)", delegate() {
                code.Write("return DOMify(?UTILITIES.CreateFileParser(filename).?GET_CONTEXT_FUNCTION());");
            });
        }

        public DOMElement_RuleDefinition()
        {
            get_type_name = new OperationCache<string>(delegate() {
                return this.ConvertInfoValue<string>("name",
                    () => GetBaseType().CreateDerivedTypeName(GetRuleId().StyleAsClassName()),
                    s => s
                );
            });

            get_store_type_name = new OperationCache<string>(delegate() {
                return this.ConvertInfoValue<string>("store_type",
                    () => GetTypeName(),
                    s => s
                );
            });

            get_retrieve_type_name = new OperationCache<string>(delegate() {
                return this.ConvertInfoValue<string>("retrieve_type",
                    () => GetStoreTypeName(),
                    s => s
                );
            });

            get_as_single = new OperationCache<DOMEVariableType>(delegate() {
                return GetGrammarDefinition().GetSettings().GetVariableTypeCreator()
                    .GetRuleDefinitionSingleFactory()
                    .Create(GetGrammarDefinition().GetElement(), this);
            });

            get_as_multiple = new OperationCache<DOMEVariableType>(delegate() {
                DOMEVariableTypeCreator creator = GetGrammarDefinition().GetSettings().GetVariableTypeCreator();

                switch (this.GetInfoValue("multiple_type"))
                {
                    case "labeled_item_set":
                        return creator.GetRuleDefinitionLabeledItemSetFactory()
                            .Create(GetGrammarDefinition().GetElement(), this,
                                GetGrammarDefinition().GetTypeConcept(this.GetInfoValue("label_type"))
                            );

                    default:
                    case "list":
                        return GetGrammarDefinition().GetSettings().GetVariableTypeCreator()
                            .GetRuleDefinitionListFactory()
                            .Create(GetGrammarDefinition().GetElement(), this);
                }
            });

            get_base_type = new OperationCache<DOMEClass>(delegate() {
                return this.ConvertInfoValue<DOMEClass>("base_type",
                    () => GetDefaultBaseType(),
                    s => GetGrammarDefinition().GetClassGeneric(s)
                );
            });

            get_context_name = new OperationCache<string>(delegate() {
                return CSLine.Single("?PARSER.?CONTEXT_ID!Context",
                    "PARSER", GetGrammarDefinition().GetParserName(),
                    "CONTEXT_ID", GetContextId().StyleAsCapitalizedEntity()
                );
            });

            get_context_default_variable_name = new OperationCache<string>(delegate() {
                return this.ConvertInfoValue("default_name",
                    () => this.ConvertInfoValue("store_type",
                        () => GetContextId().StyleAsVariableName(),
                        s => s.StyleAsVariableName()
                    ),
                    s => s
                );
            });

            get_info_settings = new OperationCache<LookupBackedSet<string, string>>(delegate() {
                return GetInfo().CreateBackedSet(DEFAULT_INFO_VALUES);
            });
        }

        public bool IsRule(string id)
        {
            if (id.EqualsEX(GetRuleId()))
                return true;

            return false;
        }

        public string GetTypeName()
        {
            return get_type_name.Fetch();
        }

        public string CreateDerivedTypeName(string name)
        {
            return GetGrammarDefinition().GetSettings().GetRuleNamer().CreateDerivedTypeName(GetTypeName(), name);
        }

        public string GetStoreTypeName()
        {
            return get_store_type_name.Fetch();
        }

        public string GetRetrieveTypeName()
        {
            return get_retrieve_type_name.Fetch();
        }

        public string GetDefaultConstructionExpression()
        {
            return "null";
        }

        public string GetContextToTypeExpression(string context_expression)
        {
            return CSLine.Single("?TYPE.DOMify(?CONTEXT_EXPRESSION)",
                "TYPE", GetTypeName(),
                "CONTEXT_EXPRESSION", context_expression
            );
        }

        public DOMEVariableType GetAsSingle()
        {
            return get_as_single.Fetch();
        }

        public DOMEVariableType GetAsMultiple()
        {
            return get_as_multiple.Fetch();
        }

        public DOMEClass GetBaseType()
        {
            return get_base_type.Fetch();
        }

        public IEnumerable<DOMEVariable> GetVariables()
        {
            return this.GetTopicalChildren<DOMEVariable>();
        }

        public string GetContextId()
        {
            return GetRuleId();
        }

        public string GetContextName()
        {
            return get_context_name.Fetch();
        }

        public string GetContextDefaultVariableName()
        {
            return get_context_default_variable_name.Fetch();
        }

        public LookupBackedSet<string, string> GetInfoSettings()
        {
            return get_info_settings.Fetch();
        }
    }
}