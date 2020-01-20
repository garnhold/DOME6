lexer grammar DOME_Tokens;

LITERAL_STRING : '\'' ('\\\''|.)*? '\'';
LITERAL_CLASS : '~'? '[' .*? ']';

RULE_ID : [a-z] [A-Za-z0-9_]*;
TOKEN_ID : [A-Z] [A-Za-z0-9_]*;

WHITESPACE : [ \r\n\t]+ -> skip;