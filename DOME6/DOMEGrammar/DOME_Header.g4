parser grammar DOME_Header;

grammarHeader : grammarType? 'grammar' id /*info: name=>grammar_name*/ ';';
importHeader : 'import' /*group:{*/ id (',' id)* /*group:}*/ /*info: name=>grammar_names*/ ';';

grammarType
    : 'parser' # grammarTypeParser
    | 'lexer' # grammarTypeLexer
    ;