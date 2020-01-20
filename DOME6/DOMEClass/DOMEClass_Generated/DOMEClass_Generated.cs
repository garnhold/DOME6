using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public interface DOMEClass_Generated : DOMEClass
    {
        DOMEClass GetBaseType();

        IEnumerable<DOMEVariable> GetVariables();

        void GenerateMainClass(CSTextDocumentBuilder text);
        bool GenerateStubClass(CSTextDocumentBuilder text);
    }
}