parser grammar DOME_TokenAtom;

tokenAtom
    : LITERAL_STRING quantifier? # tokenAtomLiteral
    | LITERAL_CLASS quantifier? # tokenAtomClass
    | '.' quantifier? # tokenAtomPeriod

    | tokenReference quantifier? info? # tokenAtomTokenReference

    | '(' tokenAtom ')' quantifier? # tokenAtomGroup
    | /*group:{*/ '(' tokenAtom ('|' tokenAtom)+ ')' /*group:}*/ quantifier? # tokenAtomAlternatives

    | /*group:{*/ tokenAtom tokenAtom+ /*group:}*/ # tokenAtomSequence

    | '/*group:{*/' tokenAtom '/*group:}*/' info? # tokenAtomInfoGroup
    ;