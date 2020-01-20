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
    public abstract class DOMEVariableType_Multiple : DOMEVariableType
    {
        protected abstract void GenerateVariableDeclarationInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings);
        protected abstract void GenerateVariableConstructionInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings);

        protected abstract string GenerateVariableDuplicateExpression(string instance);

        protected abstract void GenerateVariableClearFunctionBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings);
        protected abstract void GenerateVariableAddFunctionBody(CSTextDocumentBuilder text, DOMEVariable variable, string input, LookupBackedSet<string, string> settings);

        protected abstract string GenerateVariableGetFunctionReturnContainerType(string type);
        protected abstract string GenerateVariableGetFunctionBodyGetReturnExpression(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings);

        static private LookupSet<string, string> DEFAULT_SETTING_VALUES = new SettingTable(
            KeyValuePair.New("custom_load_context", "false"),
            KeyValuePair.New("skip_context_conversion", "false"),

            KeyValuePair.New("clear", "private"),
            KeyValuePair.New("clear_override", "false"),
            KeyValuePair.New("clear_virtual", "false"),

            KeyValuePair.New("set", "private"),
            KeyValuePair.New("set_override", "false"),
            KeyValuePair.New("set_virtual", "false"),

            KeyValuePair.New("hook_add", "false"),
            KeyValuePair.New("add", "private"),
            KeyValuePair.New("add_single", "true"),
            KeyValuePair.New("add_multiple", "true"),
            KeyValuePair.New("add_override", "false"),
            KeyValuePair.New("add_virtual", "false"),

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
                "SET_FUNCTION", settings.ConvertBool("custom_load_context", "LoadContextIntermediate" + variable.GetVariableFunctionName(), "Add" + variable.GetVariableFunctionName().StyleAsPluralWord()),
                "CONTEXT", context,
                "GET_CONTEXT_FUNCTION", variable.GetVariableContext().GetGetContextFunctionName(),
                "INDEX", index_situation.GetIndex().ToString()
            );

            string contexts_expression = "?CONTEXT.?GET_CONTEXT_FUNCTION()";
            if (index_situation.IsShared())
                contexts_expression = contexts_expression + ".Offset(?INDEX)";

            if (settings.IsTrue("skip_context_conversion"))
                code.Write("?SET_FUNCTION(" + contexts_expression + ");");
            else
            {
                string context_expression = "c";
                string value_expression = GetTypeConcept().GetContextToTypeExpression(context_expression);
                if (GetTypeConcept().GetTypeName() != GetTypeConcept().GetStoreTypeName())
                    value_expression = "(?TYPE)" + value_expression;

                string values_expression = contexts_expression + ".Convert(" + context_expression + " => " + value_expression + ")";

                code.Write("?SET_FUNCTION(" + values_expression + ");");
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

        private void GenerateVariableClearFunction(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            if (settings.IsNot("clear", "none"))
            {
                CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                    "CLEAR_ACCESS", settings.Lookup("clear"),
                    "CLEAR_OVERRIDE", settings.ConvertBool("clear_override", "override"),
                    "CLEAR_VIRTUAL", settings.ConvertBool("clear_virtual", "virtual"),
                    "CLEAR_VARIABLE_FUNCTION", "Clear" + variable.GetVariableFunctionName()
                );

                code.Write("?CLEAR_ACCESS ?CLEAR_OVERRIDE ?CLEAR_VIRTUAL void ?CLEAR_VARIABLE_FUNCTION()", delegate() {
                    GenerateVariableClearFunctionBody(text, variable, settings);
                });
            }
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
                    "CLEAR_VARIABLE_FUNCTION", "Clear" + variable.GetVariableFunctionName(),
                    "ADD_VARIABLES_FUNCTION", "Add" + variable.GetVariableFunctionName().StyleAsPluralWord()
                );

                code.Write("?SET_ACCESS ?SET_OVERRIDE ?SET_VIRTUAL void ?SET_VARIABLE_FUNCTION(IEnumerable<?TYPE> input)", delegate() {
                    code.Write("?CLEAR_VARIABLE_FUNCTION();");
                    code.Write("?ADD_VARIABLES_FUNCTION(input);");
                });

                code.Write("?SET_ACCESS void ?SET_VARIABLE_FUNCTION(params ?TYPE[] input)", delegate() {
                    code.Write("?SET_VARIABLE_FUNCTION((IEnumerable<?TYPE>)input);");
                });
            }
        }

        private void GenerateVariableAddFunction(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            if (settings.IsNot("add", "none"))
            {
                CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                    "ADD_ACCESS", settings.Lookup("add"),
                    "ADD_OVERRIDE", settings.ConvertBool("add_override", "override"),
                    "ADD_VIRTUAL", settings.ConvertBool("add_virtual", "virtual"),
                    "TYPE", GetTypeConcept().GetStoreTypeName(),
                    "VARIABLE", variable.GetVariableName(),
                    "ADD_VARIABLE_FUNCTION", "Add" + variable.GetVariableFunctionName().StyleAsSingularWord(),
                    "ADD_VARIABLES_FUNCTION", "Add" + variable.GetVariableFunctionName().StyleAsPluralWord(),
                    "ON_ADD_VARIABLE_FUNCTION", "OnAdd" + variable.GetVariableFunctionName().StyleAsSingularWord()
                );

                if (settings.IsTrue("add_single"))
                {
                    code.Write("?ADD_ACCESS ?ADD_OVERRIDE ?ADD_VIRTUAL void ?ADD_VARIABLE_FUNCTION(?TYPE input)", delegate() {
                        GenerateVariableAddFunctionBody(text, variable, "input", settings);

                        if (settings.IsTrue("hook_add"))
                            code.Write("?ON_ADD_VARIABLE_FUNCTION(input);");
                    });
                }

                if (settings.IsTrue("add_multiple"))
                {
                    code.Write("?ADD_ACCESS void ?ADD_VARIABLES_FUNCTION(IEnumerable<?TYPE> input)", delegate() {
                        if (IsSingleParentEnforced())
                            code.Write("input.ProcessCopy(i => ?ADD_VARIABLE_FUNCTION(i));");
                        else
                            code.Write("input.Process(i => ?ADD_VARIABLE_FUNCTION(i));");
                    });

                    code.Write("?ADD_ACCESS void ?ADD_VARIABLES_FUNCTION(params ?TYPE[] input)", delegate() {
                        code.Write("?ADD_VARIABLES_FUNCTION((IEnumerable<?TYPE>)input);");
                    });
                }
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
                    "RETURN_CONTAINER_TYPE", GenerateVariableGetFunctionReturnContainerType(GetTypeConcept().GetRetrieveTypeName()),
                    "VARIABLE", variable.GetVariableName(),
                    "GET_VARIABLE_FUNCTION", "Get" + variable.GetVariableFunctionName()
                );

                code.Write("?GET_ACCESS ?GET_OVERRIDE ?GET_VIRTUAL ?RETURN_CONTAINER_TYPE ?GET_VARIABLE_FUNCTION()", delegate() {
                    string return_expression = GenerateVariableGetFunctionBodyGetReturnExpression(text, variable, settings);

                    if (GetTypeConcept().GetStoreTypeName() != GetTypeConcept().GetRetrieveTypeName())
                        return_expression = return_expression + ".Convert(i => (?TYPE)i)";

                    code.Write("return " + return_expression + ";");
                });
            }
        }

        public DOMEVariableType_Multiple(DOMEVariableTypeConcept t) : base(t) { }

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

            GenerateVariableClearFunction(text, variable, settings);
            GenerateVariableSetFunction(text, variable, settings);
            GenerateVariableAddFunction(text, variable, settings);
            GenerateVariableGetFunction(text, variable, settings);
        }

        public virtual bool IsSingleParentEnforced()
        {
            return false;
        }
    }
}