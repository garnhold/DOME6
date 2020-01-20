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
    public partial class DOMElement_TokenReference : DOMElement
    {
        private OperationCache<DOMElement_TokenDefinition> resolve;

        partial void OnConstructor()
        {
            resolve = new OperationCache<DOMElement_TokenDefinition>("resolve", delegate() {
                return GetGrammarDefinition().GetDefinitions()
                    .Convert<DOMElement_Definition, DOMElement_Definition_TokenDefinition>()
                    .Convert<DOMElement_Definition_TokenDefinition, DOMElement_TokenDefinition>(d => d.GetTokenDefinition())
                    .FindFirst(d => d.IsToken(GetTokenId()));
            });
        }

        public DOMElement_TokenDefinition Resolve()
        {
            return resolve.Fetch();
        }
    }
}