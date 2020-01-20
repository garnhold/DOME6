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
    public partial class DOMElement_RuleReference : DOMElement
    {
        private OperationCache<DOMElement_RuleDefinition> resolve;

        partial void OnConstructor()
        {
            resolve = new OperationCache<DOMElement_RuleDefinition>(delegate() {
                return GetGrammarDefinition().GetDefinitions()
                    .Convert<DOMElement_Definition, DOMElement_Definition_RuleDefinition>()
                    .Convert<DOMElement_Definition_RuleDefinition, DOMElement_RuleDefinition>(d => d.GetRuleDefinition())
                    .FindFirst(d => d.IsRule(GetRuleId()));
            });
        }

        public DOMElement_RuleDefinition Resolve()
        {
            return resolve.Fetch();
        }
    }
}