using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public abstract class DOMElement_RuleDefinition_Concrete : DOMElement_RuleDefinition, DOMEVisitTarget
    {
        protected abstract void GenerateMainClassAdditionalStaticFunctions(CSTextDocumentBuilder text);
        protected abstract void GenerateMainClassDuplicateFunction(CSTextDocumentBuilder text);

        public abstract DOMElement_RuleExpression GetRuleExpression();

        protected void GenerateBasicDuplicateFunction(CSTextDocumentBuilder text, bool use_override, string return_type)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "OVERRIDE", use_override.ConvertBool("override"),
                "TYPE", GetTypeName(),
                "RETURN_TYPE", return_type
            );

            code.Write("public ?OVERRIDE ?RETURN_TYPE Duplicate()", delegate() {
                code.Write("?TYPE instance = new ?TYPE();");

                GetVariables().Process(g => g.GenerateVariableDuplicate(text, "instance"));
                code.Write("return instance;");
            });
        }

        private void GenerateMainClassVariableDeclarations(CSTextDocumentBuilder text)
        {
            if (this.IsInfoValueTrue("store_text"))
            {
                CSTextDocumentWriter code = text.CreateWriter();

                code.Write("private string stored_text;");
            }

            GetVariables().Process(g => g.GenerateVariableDeclaration(text));
        }

        private void GenerateMainClassDOMifyFunction(CSTextDocumentBuilder text)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "ACCESS", this.GetInfoValue("domify"),
                "CONTEXT", GetContextName()
            );

            code.Write("static ?ACCESS ?TYPE DOMify(?CONTEXT context)", delegate() {
                code.Write("if(context != null)", delegate() {
                    code.Write("return new ?TYPE(context);");
                }, false);

                code.Write("return null;");
            });
        }

        private void GenerateMainClassBaseConstructor(CSTextDocumentBuilder text)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "ACCESS", this.GetInfoValue("constructor")
            );

            code.Write("?ACCESS ?TYPE()", delegate() {
                GetVariables().Process(g => g.GenerateVariableConstruction(text));
                code.Write("OnConstructor();");
            });
            code.Write("partial void OnConstructor();");
        }

        private void GenerateMainClassLoadContextConstructor(CSTextDocumentBuilder text)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "ACCESS", this.GetInfoValue("constructor"),
                "CONTEXT", GetContextName()
            );

            code.Write("?ACCESS ?TYPE(?CONTEXT context) : this()", delegate() {
                GetVariables().Process(g => g.GenerateVariableLoadContext(text, "context"));

                if (this.IsInfoValueTrue("store_text"))
                    code.Write("stored_text = context.GetText();");

                if (this.IsInfoValueTrue("hook_load_context"))
                    code.Write("OnLoadContext();");
            });
        }

        private void GenerateMainClassVariableFunctions(CSTextDocumentBuilder text)
        {
            GetVariables().Process(g => g.GenerateVariableFunctions(text));
        }

        public override void GenerateMainClass(CSTextDocumentBuilder text)
        {
            if (this.IsInfoValueFalse("manual"))
            {
                CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                    "TYPE", GetTypeName(),
                    "BASE_TYPE", GetBaseType().GetTypeName()
                );

                code.Write("public partial class ?TYPE : ?BASE_TYPE", delegate() {
                    GenerateMainClassVariableDeclarations(text);

                    GenerateMainClassDOMifyFunction(text);
                    GenerateMainClassAdditionalStaticFunctions(text);

                    GenerateMainClassBaseConstructor(text);
                    GenerateMainClassLoadContextConstructor(text);

                    GenerateMainClassDuplicateFunction(text);

                    GenerateMainClassVariableFunctions(text);
                });
            }
        }

        public override bool GenerateStubClass(CSTextDocumentBuilder text)
        {
            if (this.IsInfoValueFalse("manual"))
            {
                CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                    "TYPE", GetTypeName(),
                    "BASE_TYPE", GetBaseType().GetTypeName()
                );

                code.Write("public partial class ?TYPE : ?BASE_TYPE", delegate() {
                });

                return true;
            }

            return false;
        }

        public void GenerateVisitFunction(CSTextDocumentBuilder text)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "ELEMENT", GetGrammarDefinition().GetElement().GetTypeName(),
                "VISIT_FUNCTION", "Visit" + GetRuleId().StyleAsCapitalizedEntity(),
                "CONTEXT", GetContextName(),
                "TYPE", GetTypeName(),
                "RESOLVE_FUNCTION", "Resolve" + GetRuleId().StyleAsFunctionName()
            );

            code.Write("public override ?ELEMENT ?VISIT_FUNCTION(?CONTEXT context)", delegate() {
                if (this.IsInfoValueTrue("manual"))
                    code.Write("return ?RESOLVE_FUNCTION(context);");
                else
                    code.Write("return ?TYPE.DOMify(context);");
            });
        }
    }
}