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
    public abstract class DOMElement_RuleAtom_Variable : DOMElement_RuleAtom, DOMEVariable, HasInfo
    {
        private OperationCache<string> get_variable_name;
        private OperationCache<DOMEVariableTypeConcept> get_variable_type_context;
        private OperationCache<DOMEVariableType> get_variable_type_container;

        private OperationCache<string> get_variable_default_name;
        private OperationCache<LookupBackedSet<string, string>> get_info_settings;

        public abstract bool IsVariableCollection();

        public abstract DOMEContext GetVariableContext();
        public abstract DOMEVariableTypeConcept GetDefaultVariableTypeContext();

        public abstract DOMElement_Configuration_Info GetInfo();

        static private LookupSet<string, string> DEFAULT_SETTING_VALUES = new SettingTable(
            KeyValuePair.New("name", "default"),
            KeyValuePair.New("type", "default"),

            KeyValuePair.New("manual", "false"),
            KeyValuePair.New("manual_declaration", "false")
        );

        public DOMElement_RuleAtom_Variable()
        {
            get_variable_name = new OperationCache<string>(delegate() {
                return this.ConvertInfoValue<string>("name",
                    () => GetVariableDefaultName(),
                    s => s
                );
            });

            get_variable_type_context = new OperationCache<DOMEVariableTypeConcept>(delegate() {
                return this.ConvertInfoValue<DOMEVariableTypeConcept>("type",
                    () => GetDefaultVariableTypeContext(),
                    s => GetGrammarDefinition().GetTypeConcept(s)
                );
            });

            get_variable_type_container = new OperationCache<DOMEVariableType>(delegate() {
                return GetVariableTypeConcept().Wrap(IsVariableCollection());
            });

            get_variable_default_name = new OperationCache<string>(delegate() {
                IndexSituation index_situation = this.GetVariableContextIndexSituation();
                string context_default_variable_name = GetVariableContext().GetContextDefaultVariableName();

                if (index_situation.IsShared())
                    context_default_variable_name += (index_situation.GetIndex() + 1).ToString();

                if (IsVariableCollection())
                    return context_default_variable_name.StyleAsPluralWord();

                return context_default_variable_name;
            });

            get_info_settings = new OperationCache<LookupBackedSet<string, string>>(delegate() {
                return GetInfo().CreateBackedSet(DEFAULT_SETTING_VALUES);
            });
        }
        
        public string GetVariableName()
        {
            return get_variable_name.Fetch();
        }

        public DOMEVariableTypeConcept GetVariableTypeConcept()
        {
            return get_variable_type_context.Fetch();
        }
        
        public DOMEVariableType GetVariableTypeFinalized()
        {
            return get_variable_type_container.Fetch();
        }

        public DOMEClass_Generated GetVariableHoldingClass()
        {
            return this.GetParent<DOMEClass_Generated>();
        }

        public void GenerateVariableDeclaration(CSTextDocumentBuilder text)
        {
            if (this.IsInfoValueFalse("manual") && this.IsInfoValueFalse("manual_declaration"))
                GetVariableTypeFinalized().GenerateVariableDeclaration(text, this, GetInfoSettings());
        }

        public void GenerateVariableConstruction(CSTextDocumentBuilder text)
        {
            if (this.IsInfoValueFalse("manual"))
                GetVariableTypeFinalized().GenerateVariableConstruction(text, this, GetInfoSettings());
        }

        public void GenerateVariableLoadContext(CSTextDocumentBuilder text, string context)
        {
            GetVariableTypeFinalized().GenerateVariableLoadContext(text, context, this, GetInfoSettings());
        }

        public void GenerateVariableDuplicate(CSTextDocumentBuilder text, string instance)
        {
            GetVariableTypeFinalized().GenerateVariableDuplicate(text, instance, this, GetInfoSettings());
        }

        public void GenerateVariableFunctions(CSTextDocumentBuilder text)
        {
            if (this.IsInfoValueFalse("manual"))
                GetVariableTypeFinalized().GenerateVariableFunctions(text, this, GetInfoSettings());
        }

        public string GetVariableDefaultName()
        {
            return get_variable_default_name.Fetch();
        }

        public LookupBackedSet<string, string> GetInfoSettings()
        {
            return get_info_settings.Fetch();
        }
    }
}