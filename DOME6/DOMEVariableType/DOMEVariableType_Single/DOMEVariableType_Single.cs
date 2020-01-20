using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public abstract class DOMEVariableType_Single : DOMEVariableType
    {
        protected abstract void GenerateVariableDeclarationInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings);
        protected abstract void GenerateVariableConstructionInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings);

        protected abstract string GenerateVariableDuplicateExpression(string instance);

        protected abstract void GenerateVariableSetFunctionBody(CSTextDocumentBuilder text, DOMEVariable variable, string input, LookupBackedSet<string, string> settings);
        protected abstract string GenerateVariableGetFunctionBodyGetReturnExpression(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings);

        static private LookupSet<string, string> DEFAULT_SETTING_VALUES = new SettingTable(
            KeyValuePair.New("custom_load_context", "false"),
            KeyValuePair.New("skip_context_conversion", "false"),

            KeyValuePair.New("hook_set", "false"),
            KeyValuePair.New("set", "private"),
            KeyValuePair.New("set_override", "false"),
            KeyValuePair.New("set_virtual", "false"),

            KeyValuePair.New("get", "public"),
            KeyValuePair.New("get_override", "false"),
            KeyValuePair.New("get_virtual", "false")
        );

        private void GenerateVariableDeclarationInternal(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            GenerateVariableDeclarationInternalBody(text, variable, settings);
        }

        private void GenerateVariableConstructionInternal(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            GenerateVariableConstructionInternalBody(text, variable, settings);
        }

        private void GenerateVariableLoadContextInternal(CSTextDocumentBuilder text, string context, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            IndexSituation index_situation = variable.GetVariableContextIndexSituation();
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeConcept().GetStoreTypeName(),
                "SET_FUNCTION", settings.ConvertBool("custom_load_context", "LoadContextIntermediate" + variable.GetVariableFunctionName(), "Set" + variable.GetVariableFunctionName()),
                "CONTEXT", context,
                "GET_CONTEXT_FUNCTION", variable.GetVariableContext().GetGetContextFunctionName(),
                "INDEX", index_situation.GetIndex().ToString()
            );

            string context_expression = "?CONTEXT.?GET_CONTEXT_FUNCTION()";
            if (index_situation.IsShared())
                context_expression = "?CONTEXT.?GET_CONTEXT_FUNCTION(?INDEX)";

            if (settings.IsTrue("skip_context_conversion"))
                code.Write("?SET_FUNCTION(" + context_expression + ");");
            else
            {
                string value_expression = GetTypeConcept().GetContextToTypeExpression(context_expression);
                if (GetTypeConcept().GetTypeName() != GetTypeConcept().GetStoreTypeName())
                    value_expression = "(?TYPE)" + value_expression;

                code.Write("?SET_FUNCTION(" + value_expression + ");");
            }
        }

        private void GenerateVariableDuplicateInternal(CSTextDocumentBuilder text, string instance, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "INSTANCE", instance,
                "SET_VARIABLE_FUNCTION", "Set" + variable.GetVariableFunctionName()
            );

            string input_expression = "Get" + variable.GetVariableFunctionName() + "()";
            string duplicate_expression = GenerateVariableDuplicateExpression(input_expression);

            code.Write("?INSTANCE.?SET_VARIABLE_FUNCTION(" + duplicate_expression + ");");
        }

        private void GenerateVariableSetFunction(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            if (settings.IsNot("set", "none"))
            {
                CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                    "SET_ACCESS", settings.Lookup("set"),
                    "SET_OVERRIDE", settings.ConvertBool("set_override", "override"),
                    "SET_VIRTUAL", settings.ConvertBool("set_virtual", "virtual"),
                    "TYPE", GetTypeConcept().GetStoreTypeName(),
                    "VARIABLE", variable.GetVariableName(),
                    "SET_VARIABLE_FUNCTION", "Set" + variable.GetVariableFunctionName(),
                    "ON_SET_VARIABLE_FUNCTION", "OnSet" + variable.GetVariableFunctionName()
                );

                code.Write("?SET_ACCESS ?SET_OVERRIDE ?SET_VIRTUAL void ?SET_VARIABLE_FUNCTION(?TYPE input)", delegate() {
                    GenerateVariableSetFunctionBody(text, variable, "input", settings);

                    if (settings.IsTrue("hook_set"))
                        code.Write("?ON_SET_VARIABLE_FUNCTION(input);");
                });
            }
        }

        private void GenerateVariableGetFunction(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            if (settings.IsNot("get", "none"))
            {
                CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                    "GET_ACCESS", settings.Lookup("get"),
                    "GET_OVERRIDE", settings.ConvertBool("get_override", "override"),
                    "GET_VIRTUAL", settings.ConvertBool("get_virtual", "virtual"),
                    "TYPE", GetTypeConcept().GetRetrieveTypeName(),
                    "VARIABLE", variable.GetVariableName(),
                    "GET_VARIABLE_FUNCTION", "Get" + variable.GetVariableFunctionName()
                );

                code.Write("?GET_ACCESS ?GET_OVERRIDE ?GET_VIRTUAL ?TYPE ?GET_VARIABLE_FUNCTION()", delegate() {
                    string return_expression = GenerateVariableGetFunctionBodyGetReturnExpression(text, variable, settings);

                    if(GetTypeConcept().GetStoreTypeName() != GetTypeConcept().GetRetrieveTypeName())
                        return_expression = "(?TYPE)" + return_expression;
                        
                    code.Write("return " + return_expression + ";");
                });
            }
        }

        public DOMEVariableType_Single(DOMEVariableTypeConcept t) : base(t) { }

        public override void GenerateVariableDeclaration(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            settings = settings.AppendFallbacks(DEFAULT_SETTING_VALUES);

            GenerateVariableDeclarationInternal(text, variable, settings);
        }

        public override void GenerateVariableConstruction(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            settings = settings.AppendFallbacks(DEFAULT_SETTING_VALUES);

            GenerateVariableConstructionInternal(text, variable, settings);
        }

        public override void GenerateVariableLoadContext(CSTextDocumentBuilder text, string context, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            settings = settings.AppendFallbacks(DEFAULT_SETTING_VALUES);

            GenerateVariableLoadContextInternal(text, context, variable, settings);
        }

        public override void GenerateVariableDuplicate(CSTextDocumentBuilder text, string instance, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            settings = settings.AppendFallbacks(DEFAULT_SETTING_VALUES);

            GenerateVariableDuplicateInternal(text, instance, variable, settings);
        }

        public override void GenerateVariableFunctions(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            settings = settings.AppendFallbacks(DEFAULT_SETTING_VALUES);

            GenerateVariableSetFunction(text, variable, settings);
            GenerateVariableGetFunction(text, variable, settings);
        }
    }
}