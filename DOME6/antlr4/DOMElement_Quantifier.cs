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
    public abstract partial class DOMElement_Quantifier : DOMElement
    {
        public abstract bool IsQuantifierMultiple();
    }

    public partial class DOMElement_Quantifier_NoneOrMore : DOMElement_Quantifier
    {
        public override bool IsQuantifierMultiple() { return true; }
    }

    public partial class DOMElement_Quantifier_NoneOrOne : DOMElement_Quantifier
    {
        public override bool IsQuantifierMultiple() { return false; }
    }

    public partial class DOMElement_Quantifier_OneOrMore : DOMElement_Quantifier
    {
        public override bool IsQuantifierMultiple() { return true; }
    }
}