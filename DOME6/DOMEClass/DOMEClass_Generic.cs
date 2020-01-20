using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public class DOMEClass_Generic : DOMEClass
    {
        private string type_name;
        private DOMElement_GrammarDefinition grammar_definition;

        public DOMEClass_Generic(DOMElement_GrammarDefinition g, string n)
        {
            type_name = n;
            grammar_definition = g;
        }

        public string GetTypeName()
        {
            return type_name;
        }

        public string CreateDerivedTypeName(string name)
        {
            return GetGrammarDefinition().GetSettings().GetGenericNamer().CreateDerivedTypeName(GetTypeName(), name);
        }

        public DOMElement_GrammarDefinition GetGrammarDefinition()
        {
            return grammar_definition;
        }
    }
}