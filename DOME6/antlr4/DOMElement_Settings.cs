//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 4/5/2016 11:12:29 AM

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
    public partial class DOMElement_Settings : DOMElement, LookupSet<string, string>
    {
        public bool HasSetting(string name)
        {
            return GetSettings().Has(s => s.IsSetting(name));
        }

        public bool TryGetSetting(string name, out DOMElement_Setting output)
        {
            return GetSettings().TryFindFirst(s => s.IsSetting(name), out output);
        }

        public bool Has(string name)
        {
            return HasSetting(name);
        }

        public bool TryLookup(string name, out string value)
        {
            DOMElement_Setting setting;

            if (TryGetSetting(name, out setting))
            {
                value = setting.GetValue();
                return true;
            }

            value = "";
            return false;
        }
    }
}