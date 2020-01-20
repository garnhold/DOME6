using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public class DOMEVariableType_Single_Primitive : DOMEVariableType_Single
    {
        protected override void GenerateVariableDeclarationInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "TYPE", GetTypeName(),
                "VARIABLE", variable.GetVariableName()
            );

            code.Write("private ?TYPE ?VARIABLE;");
        }

        protected override void GenerateVariableConstructionInternalBody(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "VARIABLE", variable.GetVariableName(),
                "EXPRESSION", GetTypeConcept().GetDefaultConstructionExpression()
            );

            code.Write("?VARIABLE = ?EXPRESSION;");
        }

        protected override string GenerateVariableDuplicateExpression(string instance)
        {
            return instance;
        }

        protected override void GenerateVariableSetFunctionBody(CSTextDocumentBuilder text, DOMEVariable variable, string input, LookupBackedSet<string, string> settings)
        {
            CSTextDocumentWriter code = text.CreateWriterWithVariablePairs(
                "VARIABLE", variable.GetVariableName(),
                "INPUT", input
            );

            code.Write("?VARIABLE = ?INPUT;");
        }

        protected override string GenerateVariableGetFunctionBodyGetReturnExpression(CSTextDocumentBuilder text, DOMEVariable variable, LookupBackedSet<string, string> settings)
        {
            return CSLine.Single("?VARIABLE",
                "VARIABLE", variable.GetVariableName()
            );
        }

        public DOMEVariableType_Single_Primitive(DOMEVariableTypeConcept t) : base(t) { }

        public override string GetTypeName()
        {
            return GetTypeConcept().GetStoreTypeName();
        }
    }
}