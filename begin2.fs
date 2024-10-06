\ Begin2. Дана сторона квадрата a. Найти его площадь S = a^2 

: POW2 ( x -- y ) \ y = x*x
DUP \   x -- x x
*   \   x x -- x*x    
;

: B2 ( a -- S ) \ S = a^2
POW2    \ a -- a*a
; 

S" test/ttester.fs" included

t{ 4 B2 -> 16 }t
t{ 5 B2 -> 25 }t
t{ 0 B2 -> 0 }t
t{ 1 B2 -> 1 }t