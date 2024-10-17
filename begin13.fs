\ Begin13. Даны два круга с общим центром и радиусами R1 и R2 ( R1 > R2 ). Найти
\ площади этих кругов S1 и S2 , а также площадь S3 кольца, внешний радиус
\ которого равен R1 , а внутренний радиус равен R2 :
\ S1 = π·(R1)^2 ,
\ S2 = π·(R2)^2 ,
\ S3 = S1–S2 
\ В качестве значения π использовать 3.14.

: SQUARE ( r -- π·r^2 )
DUP * 314 *
;

: B13INT ( r1 r2 -- s1 s2 s3 ) \ S1 = π·R1^2, S2 = π·R2^2, S3 = S1–S2 
SQUARE ( r1 S2 )
SWAP ( S2 r1 )
SQUARE ( S2 S1 )
SWAP ( S1 S2 )
2DUP ( S1 S2 S1 S2 )
- 
;

: FSQUARE ( r -- π·r^2 )
FDUP F* 3.14E F*
;

: F2DUP ( a b -- a b a b )
FOVER FOVER ;

: B13 ( r1 r2 -- s1 s2 s3 ) \ S1 = π·R1^2, S2 = π·R2^2, S3 = S1–S2 
FSQUARE ( r1 S2 )
FSWAP ( S2 r1 )
FSQUARE ( S2 S1 )
FSWAP ( S1 S2 )
F2DUP ( S1 S2 S1 S2 )
F- 
;

S" test/ttester.fs" included

1e-4 abs-near f!  set-near

t{ 1 SQUARE -> 314 }t
t{ 2 SQUARE -> 1256 }t
t{ 3 SQUARE -> 2826 }t

t{ 3 1 B13INT -> 2826 314 2512 }t

t{ 1E FSQUARE -> 3.14E }t
t{ 2E FSQUARE -> 12.56E }t
t{ 3E FSQUARE -> 28.26E }t

t{ 3E 1E B13 -> 28.26E 3.14E 25.12E }t
