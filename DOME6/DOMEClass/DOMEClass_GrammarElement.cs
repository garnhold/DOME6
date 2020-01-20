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
    public abstract class DOMEClass_GrammarElement : DOMEClass
    {
        private DOMElement_GrammarDefinition grammar_definition;

        public abstract string GetTypeName();

        public DOMEClass_GrammarElement(DOMElement_GrammarDefinition g)
        {
            grammar_definition = g;
        }

        public string CreateDerivedTypeName(string name)
        {
            return GetGrammarDefinition().GetSettings().GetGrammarNamer().CreateDerivedTypeName(GetTypeName(), name);
        }

        public DOMElement_GrammarDefinition GetGrammarDefinition()
        {
            return grammar_definition;
        }
    }
}