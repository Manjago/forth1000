\ Begin5. Дана длина ребра куба a. Найти объем куба V = a^3 и площадь его поверхности S = 6·a^2 

: CUBE_V ( a -- V) \ V = a*a*a
DUP DUP * *
;

: CUBE_S ( a -- S) \ S = 6*a*a
DUP * 6 *
;

: B5 ( a -- S V ) \ S = 6*a*a, V = a*a*a
DUP CUBE_S SWAP CUBE_V 
; 

S" test/ttester.fs" included

t{ 2 CUBE_V -> 8 }t
t{ 1 CUBE_V -> 1 }t
t{ 0 CUBE_V -> 0 }t

t{ 2 CUBE_S -> 24 }t
t{ 1 CUBE_S -> 6 }t
t{ 0 CUBE_S -> 0 }t

t{ 2 B5 -> 24 8 }t
t{ 1 B5 -> 6 1 }t
t{ 0 B5 -> 0 0 }t