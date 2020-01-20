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
    public partial class DOMElement_TokenDefinition : DOMElement, DOMEContext, HasInfo
    {
        private OperationCache<string> get_context_default_variable_name;
        private OperationCache<LookupBackedSet<string, string>> get_info_settings;

        static private LookupSet<string, string> DEFAULT_INFO_VALUES = new SettingTable(
            KeyValuePair.New("type", "string")
        );

        partial void OnConstructor()
        {
            get_context_default_variable_name = new OperationCache<string>(delegate() {
                return GetContextId().StyleAsVariableName();
            });

            get_info_settings = new OperationCache<LookupBackedSet<string, string>>(delegate() {
                return GetInfo().CreateBackedSet(DEFAULT_INFO_VALUES);
            });
        }

        public bool IsToken(string id)
        {
            if (id.EqualsEX(GetTokenId()))
                return true;

            return false;
        }

        public string GetContextId()
        {
            return GetTokenId();
        }

        public string GetContextName()
        {
            return "ITerminalNode";
        }

        public string GetGetContextFunctionName()
        {
            return GetTokenId();
        }

        public string GetContextDefaultVariableName()
        {
            return get_context_default_variable_name.Fetch();
        }

        public DOMEVariableTypeConcept GetDefaultVariableTypeInternal()
        {
            return GetGrammarDefinition().GetTypeConcept(this.GetInfoValue("type"));
        }

        public LookupBackedSet<string, string> GetInfoSettings()
        {
            return get_info_settings.Fetch();
        }
    }
}