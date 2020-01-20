parser grammar DOME_Settings;

settings : /*group:{*/ setting (',' setting)* /*group:}*/;
setting
    : id /*info: name=>name,get_override*/  # setting_Flag
    | id /*info: name=>name,get_override*/ '=>' id /*info: name=>value,get_override*/  # setting_Value
    ;