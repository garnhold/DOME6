parser grammar DOME_Definition;

definition
    : ruleDefinitionConcreteDirect # definition_RuleDefinition_ConcreteDirect /*info: base_type=>DOMElement_Definition_RuleDefinition*/
    | ruleDefinitionConcreteInherited # definition_RuleDefinition_ConcreteInherited /*info: base_type=>DOMElement_Definition_RuleDefinition*/
    | ruleDefinitionAbstract # definition_RuleDefinition_Abstract /*info: base_type=>DOMElement_Definition_RuleDefinition*/
    | tokenDefinition # definition_TokenDefinition
    ;