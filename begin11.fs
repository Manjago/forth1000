\ Begin11. Даны два ненулевых числа. Найти сумму, разность, произведение и частное их модулей.

: TO2 ( a b -- |a| |b| )
SWAP ( b a )
ABS ( b |a| )
SWAP ( |a| b )
ABS ( |a| |b|)
;

S" begin-common.fs" included

: B11 ( a b -- |a|+|b|, |a|-|b|, |a|*|b|, |a|/|b| )
TO2 ( |a| |b| )
ALL_AR
;

S" test/ttester.fs" included

t{ -3 4 TO2 -> 3 4 }t
t{ 2 -4 TO2 -> 2 4 }t
t{ 6 -3 B11 -> 9 3 18 2 }t