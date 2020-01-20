using System;

using Crunchy.Dough;
using Crunchy.Noodle;
using Crunchy.Ginger;

namespace DOME
{
    public interface DOMEContext
    {
        string GetContextId();
        string GetContextName();
        string GetGetContextFunctionName();
        string GetContextDefaultVariableName();
    }
}