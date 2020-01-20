parser grammar DOME_RuleAtom;

ruleAtom
    : LITERAL_STRING /*info: custom_load_context*/ quantifier? # ruleAtomLiteral

    | tokenReference quantifier? /*info: get_override*/ info? /*info: get_override*/ # ruleAtomTokenReference /*info: base_type=>DOMElement_RuleAtom_Variable_Reference*/
    | ruleReference quantifier? /*info: get_override*/ info? /*info: get_override*/ # ruleAtomRuleReference /*info: base_type=>DOMElement_RuleAtom_Variable_Reference*/

    | '(' ruleExpression ')' quantifier? # ruleAtomGroup
    | '/*group:{*/' ruleExpression '/*group:}*/' info? /*info: get_override*/ # ruleAtomInfoGroup /*info: hook_constructor, base_type=>DOMElement_RuleAtom_Variable*/
    ;