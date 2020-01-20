using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public abstract class DOMEVariableTypeConcept_Primitive : DOMEVariableTypeConcept
    {
        private string name;
        private DOMElement_GrammarDefinition grammar_definition;

        private OperationCache<DOMEVariableType> get_as_single;
        private OperationCache<DOMEVariableType> get_as_collection;

        public abstract string GetDefaultConstructionExpression();
        public abstract string GetStringToTypeExpression(string string_expression);

        public DOMEVariableTypeConcept_Primitive(DOMElement_GrammarDefinition g, string n)
        {
            name = n;
            grammar_definition = g;

            get_as_single = new OperationCache<DOMEVariableType>("get_as_single", delegate() {
                return new DOMEVariableType_Single_Primitive(this);
            });

            get_as_collection = new OperationCache<DOMEVariableType>("get_as_collection", delegate() {
                return new DOMEVariableType_Multiple_Primitive_List(this);
            });
        }

        public string GetTypeName()
        {
            return name;
        }

        public string GetStoreTypeName()
        {
            return GetTypeName();
        }

        public string GetRetrieveTypeName()
        {
            return GetTypeName();
        }

        public string GetContextToTypeExpression(string context_expression)
        {
            return GetStringToTypeExpression(GetContextToStringExpression(context_expression));
        }

        public string GetContextToStringExpression(string context_expression)
        {
            return CSLine.Single("?CONTEXT_EXPRESSION.GetTextEX()",
                "CONTEXT_EXPRESSION", context_expression
            );
        }

        public DOMEVariableType GetAsSingle()
        {
            return get_as_single.Fetch();
        }

        public DOMEVariableType GetAsMultiple()
        {
            return get_as_collection.Fetch();
        }

        public DOMElement_GrammarDefinition GetGrammarDefinition()
        {
            return grammar_definition;
        }
    }
}