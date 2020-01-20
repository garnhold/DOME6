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
    public abstract class DOMElement_Configuration : DOMElement, LookupSet<string, string>
    {
        public abstract DOMElement_Settings GetSettings();

        public bool Has(string name)
        {
            return GetSettings().Has(name);
        }

        public bool TryLookup(string name, out string value)
        {
            return GetSettings().TryLookup(name, out value);
        }
    }
}