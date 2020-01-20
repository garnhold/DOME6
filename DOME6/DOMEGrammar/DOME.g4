grammar DOME;
import
DOME_Definition,
DOME_General,
DOME_Header,
DOME_Info,
DOME_Quantifier,
DOME_Rule,
DOME_RuleAtom,
DOME_RuleExpression,
DOME_Settings,
DOME_Token,
DOME_TokenAtom,
DOME_Tokens;

grammarDefinition /*info: hook_constructor */ : grammarHeader importHeader? /*info: hook_set*/ definition*;