﻿//-------------------------------
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
    public partial class DOMElement_RuleAtom_Literal : DOMElement_RuleAtom, HasQuantifier
    {
        private void LoadContextIntermediateLiteralString(string input)
        {
            SetLiteralString(input.TrimPrefixAndSuffix("'"));
        }
    }
}