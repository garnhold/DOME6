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
    public abstract class DOMElement_Definition_RuleDefinition : DOMElement_Definition
    {
        public abstract DOMElement_RuleDefinition GetRuleDefinition();
    }
}