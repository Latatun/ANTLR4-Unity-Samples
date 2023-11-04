grammar Hello;
r  : ('Hello' | 'hello') ID ;
ID : ([A-Z] | [a-z])+ ; 
WS : [ \t\r\n]+ -> skip ;