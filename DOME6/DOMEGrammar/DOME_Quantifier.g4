parser grammar DOME_Quantifier;

quantifier
    : '?' # quantifierNoneOrOne
    | '*' '?'? # quantifierNoneOrMore
    | '+' '?'? # quantifierOneOrMore
    ;