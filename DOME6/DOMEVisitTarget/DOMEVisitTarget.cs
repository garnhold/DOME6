using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Ginger;

public interface DOMEVisitTarget
{
    void GenerateVisitFunction(CSTextDocumentBuilder text);
}

static public class DOMEVisitTargetExtensions
{
}