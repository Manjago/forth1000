
\ Begin1. Дана сторона квадрата a. Найти его периметр P = 4·a.
: B1 ( a -> P) \ P = 4*a
4 * 
;

S" test/ttester.fs" included

t{ 4 B1 -> 16 }t
t{ 5 B1 -> 20 }t
t{ 0 B1 -> 0 }t
