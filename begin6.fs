\ Begin6. Даны длины ребер a, b, c прямоугольного параллелепипеда. 
\ Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c).

: 3MIRROR ( a b c -- a b c c b a )
DUP 2OVER SWAP
;

: V3D ( a b c -- V ) \ V = a*b*c
* *
;

: S3D ( a b c -- S ) \ S = 2*(a*b + b*c + a*c)
3MIRROR ( a b c -- a b c c b a )
ROT ( a b c c b a -- a b c a c b )
* ( a b c a c b -- a b c a c*b )
1 ( a b c a c*b -- a b c a c*b 1 )
2ROT ( a b c a c*b 1 -- c a c*b 1 a b )
* * ( c a c*b 1 a b -- c a c*b a*b )
2SWAP ( c a c*b a*b -- c*b a*b c a ) 
* ( c*b a*b c a -- c*b a*b c*a )
+ + 2 *
;

: B6 ( a b c -- S V) \ S = 2*(a*b + b*c + a*c), V = a*b*c 
3MIRROR ( a b c -- a b c c b a )
S3D ( a b c c b a -- a b c S )
SWAP ( a b c S -- a b S c )
2SWAP ( a b S c -- S c a b )
V3D ( S c a b -- S V )
;

S" test/ttester.fs" included

t{ 1 2 3 3MIRROR -> 1 2 3 3 2 1 }t
t{ 2 3 5 V3D -> 30 }t
t{ 2 3 5 S3D -> 62 }t
t{ 2 3 5 B6 -> 62 30 }t
t{ 1 2 3 B6 -> 22 6 }t
