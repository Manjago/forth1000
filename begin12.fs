\ Begin12. Даны катеты прямоугольного треугольника a и b . Найти его гипотенузу c и периметр P :
\ c = SQRT(a^2 + b^2) 
\ P = a + b + c .

: F2DUP ( a b -- a b a b )
FOVER FOVER ;

: F-ROT ( a b c -- c a b )
FROT FROT
;

: HYP ( a b -- c ) \ c = SQRT(a^2 + b^2)
FDUP ( a b b )
F* ( a b^2 )
FSWAP ( b^2 a )
FDUP ( b^2 a a )
F* ( b^2 a^2 )
F+ ( a^2 + b^2 )
FSQRT
;

: PERIMETER ( a b c -- P ) \ P = a + b + c
F+ F+
;

: B12 ( a b -- c P ) \ c = SQRT(a^2 + b^2), P = a + b + c  
F2DUP ( a b a b )
HYP ( a b c )
F-ROT ( c a b ) 
FTHIRD ( c a b c )
PERIMETER ( c P )
;

S" test/ttester.fs" included

1e-2 abs-near f!  set-near

t{ 3E 4E HYP -> 5E }t
t{ 1E 2E 4E PERIMETER -> 7E }t
t{ 3E 4E B12 -> 5E 12E }t
