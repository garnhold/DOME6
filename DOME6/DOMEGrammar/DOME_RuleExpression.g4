parser grammar DOME_RuleExpression;

ruleExpression
    : ruleAtom+ # ruleExpression_Sequence
    | /*group:{*/ ruleExpression ('|' ruleExpression)+ /*group:}*/ # ruleExpression_Alternatives
    ;