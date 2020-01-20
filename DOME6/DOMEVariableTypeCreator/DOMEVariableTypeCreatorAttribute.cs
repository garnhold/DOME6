using System;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;

namespace DOME
{
    [AttributeUsage(AttributeTargets.Field)]
    public class DOMEVariableTypeCreatorAttribute : ConfigurationValue_BasicAttribute
    {
        public DOMEVariableTypeCreatorAttribute(params string[] o) : base(o)
        {
        }
    }
}