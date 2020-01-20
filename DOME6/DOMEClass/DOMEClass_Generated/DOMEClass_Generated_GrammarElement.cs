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
    public abstract class DOMEClass_Generated_GrammarElement : DOMEClass_GrammarElement, DOMEClass_Generated
    {
        public abstract DOMEClass GetBaseType();
        public abstract void GenerateMainClass(CSTextDocumentBuilder text);
        public abstract bool GenerateStubClass(CSTextDocumentBuilder text);

        public DOMEClass_Generated_GrammarElement(DOMElement_GrammarDefinition g)
            : base(g)
        {
        }

        public IEnumerable<DOMEVariable> GetVariables()
        {
            return EmptyEnumerable<DOMEVariable>.INSTANCE;
        }
    }
}