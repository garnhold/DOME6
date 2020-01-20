using System;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;

namespace DOME
{
    public class DOMESettings
    {
        [ConfigurationVariable_Interpret("grammar", "The name of the grammar", "", "g", "PRIMARY")]
        private string grammar_name;

        [ConfigurationVariable_Interpret("element", "The name of the base grammar element", "", "e")]
        private string element_name;

        [ConfigurationVariable_Interpret("element_base_type", "The name of the base grammar element's base type", "Object", "b")]
        private string element_base_type_name;

        [ConfigurationVariable_Interpret("exception_base_type", "The name of the syntax exception's base exception", "Exception", "x")]
        private string exception_base_type_name;

        [ConfigurationVariable_Interpret("namespace", "The name of the namespace of the generated classes", "", "n")]
        private string namespace_name;

        [ConfigurationVariable_Lookup("variable_type_creator", "The name of the type wrapping style", "Auto", typeof(DOMEVariableTypeCreatorAttribute), "v")]
        private DOMEVariableTypeCreator variable_type_creator;

        [ConfigurationVariable_Create("generic_namer", "The name of the namer used to name generic classes", "Explicit", typeof(DOMENamerAttribute), "gn")]
        private DOMENamer generic_namer;

        [ConfigurationVariable_Create("rule_namer", "The name of the namer used to name rule derived classes", "Explicit", typeof(DOMENamerAttribute), "rn")]
        private DOMENamer rule_namer;

        [ConfigurationVariable_Create("grammar_namer", "The name of the namer used to name base classes", "Explicit", typeof(DOMENamerAttribute), "bn")]
        private DOMENamer grammar_namer;

        [ConfigurationVariable_Interpret("output_directory", "The directory to output to", "", "o")]
        private string output_directory;

        [ConfigurationVariable_Interpret("should_generate_stub_classes", "Flag to generate stub classes", "false", "c")]
        private bool should_generate_stub_classes;

        public string GetGrammarName()
        {
            return grammar_name;
        }

        public string GetElementName()
        {
            return element_name;
        }

        public string GetElementBaseTypeName()
        {
            return element_base_type_name;
        }

        public string GetExceptionBaseTypeName()
        {
            return exception_base_type_name;
        }

        public string GetNamespaceName()
        {
            return namespace_name.CoalesceBlank(GetGrammarName());
        }

        public DOMEVariableTypeCreator GetVariableTypeCreator()
        {
            return variable_type_creator;
        }

        public DOMENamer GetGenericNamer()
        {
            return generic_namer;
        }

        public DOMENamer GetRuleNamer()
        {
            return rule_namer;
        }

        public DOMENamer GetGrammarNamer()
        {
            return grammar_namer;
        }

        public string GetOutputDirectory()
        {
            return output_directory;
        }

        public bool ShouldGenerateStubClasses()
        {
            return should_generate_stub_classes;
        }
    }
}