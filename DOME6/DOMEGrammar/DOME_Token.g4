parser grammar DOME_Token;

tokenReference /*info: hook_constructor */ : TOKEN_ID;

tokenDefinition /*info: hook_constructor */ : TOKEN_ID info? ':' tokenAtom ('->' id)? ';';