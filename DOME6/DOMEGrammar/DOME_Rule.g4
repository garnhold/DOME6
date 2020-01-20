parser grammar DOME_Rule;

ruleReference /*info: hook_constructor */ : RULE_ID;

ruleDefinitionConcreteDirect /*info: base_type=>DOMElement_RuleDefinition_Concrete*/ : RULE_ID /*info: get_override*/ info? /*info: get_override*/ ':' ruleExpression /*info: get_override*/ ';';
ruleDefinitionConcreteInherited /*info: base_type=>DOMElement_RuleDefinition_Concrete*/ : ruleExpression /*info: get_override*/ '#' RULE_ID /*info: get_override*/ info? /*info: get_override*/;

ruleDefinitionAbstract /*info: base_type=>DOMElement_RuleDefinition*/ : RULE_ID /*info: get_override*/ info? /*info: get_override*/ ':' /*group:{*/ ruleDefinitionConcreteInherited ('|' ruleDefinitionConcreteInherited)* /*group:}*/ ';';