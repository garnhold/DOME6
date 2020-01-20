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
    [DOMENamer("Implicit")]
    public class DOMENamer_Implicit : DOMENamer
    {
        public override string CreateDerivedTypeName(string base_name, string name)
        {
            return name;
        }
    }
}