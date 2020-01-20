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
    public abstract class DOMEVariableType
    {
        private DOMEVariableTypeConcept type_concept;

        public abstract string GetTypeName();

        public abstract void GenerateVariableDeclaration(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings);
        public abstract void GenerateVariableConstruction(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings);
        public abstract void GenerateVariableLoadContext(CSTextDocumentBuilder text, string context, DOMEVariable variable, LookupBackedSet<string, string> settings);
        public abstract void GenerateVariableDuplicate(CSTextDocumentBuilder text, string instance, DOMEVariable variable, LookupBackedSet<string, string> settings);
        public abstract void GenerateVariableFunctions(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings);

        public DOMEVariableType(DOMEVariableTypeConcept t)
        {
            type_concept = t;
        }

        public DOMEVariableTypeConcept GetTypeConcept()
        {
            return type_concept;
        }
    }
}