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
    public abstract partial class DOMElement_Setting : DOMElement
    {
        public abstract string GetName();
        public abstract string GetValue();

        public bool IsSetting(string name)
        {
            if (name.AreWordInvariantsEqual(GetName()))
                return true;

            return false;
        }
    }

    public partial class DOMElement_Setting_Flag : DOMElement_Setting
    {
        public override string GetValue() { return "true"; }
    }

    public partial class DOMElement_Setting_Value : DOMElement_Setting
    {
    }
}