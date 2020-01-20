using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public interface DOMEVariable
    {
        string GetVariableName();

        DOMEContext GetVariableContext();

        DOMEVariableTypeConcept GetVariableTypeConcept();
        DOMEVariableType GetVariableTypeFinalized();

        DOMEClass_Generated GetVariableHoldingClass();

        void GenerateVariableDeclaration(CSTextDocumentBuilder text);
        void GenerateVariableConstruction(CSTextDocumentBuilder text);
        void GenerateVariableLoadContext(CSTextDocumentBuilder text, string context);
        void GenerateVariableDuplicate(CSTextDocumentBuilder text, string instance);
        void GenerateVariableFunctions(CSTextDocumentBuilder text);
    }

    static public class DOMEVariableExtensions
    {
        static public string GetVariableFunctionName(this DOMEVariable item)
        {
            return item.GetVariableName().StyleAsFunctionName();
        }

        static public IEnumerable<DOMEVariable> GetVariableSibilings(this DOMEVariable item)
        {
            return item.GetVariableHoldingClass().GetVariables();
        }

        static public IndexSituation GetVariableContextIndexSituation(this DOMEVariable item)
        {
            return item.GetVariableSibilings()
                .Narrow(v => v.GetVariableContext() == item.GetVariableContext())
                .DetermineIndexSituation(item);
        }
    }
}