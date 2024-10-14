\ Begin10. Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов.

: TO2 ( a b -- a^2 b^2 )
SWAP ( b a )
DUP ( b a a )
* ( b a^2 )
SWAP ( a^2 b )
DUP ( a^2 b b )
* ( a^2 b^2)
;

: B10 ( a b -- a^2+b^2, a^2-b^2, a^2*b^2, a^2/b^2 )
TO2 ( a^2 b^2 )
2DUP ( a^2 b^2 a^2 b^2 )
+ ( a^2 b^2 a^2+b^2 )
-ROT ( a^2+b^2 a^2 b^2 )
2DUP ( a^2+b^2 a^2 b^2 a^2 b^2 )
- ( a^2+b^2 a^2 b^2 a^2-b^2 )
-ROT ( a^2+b^2 a^2-b^2 a^2 b^2 )
2DUP ( a^2+b^2 a^2-b^2 a^2 b^2 a^2 b^2 )
* ( a^2+b^2 a^2-b^2 a^2 b^2 a^2*b^2 )
-ROT ( a^2+b^2 a^2-b^2 a^2*b^2 a^2 b^2 )
/ ( a^2+b^2 a^2-b^2 a^2*b^2 a^2/b^2 )
;

S" test/ttester.fs" included

t{ 3 4 TO2 -> 9 16 }t
t{ 2 4 TO2 -> 4 16 }t
t{ 4 2 B10 -> 20 12 64 4 }t