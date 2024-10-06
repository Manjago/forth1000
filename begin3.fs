\ Begin3°. Даны стороны прямоугольника a и b. Найти его площадь S = a·b и периметр P = 2·(a + b).

: SQUARE ( a b -- S ) \ S=a*b
*
;

: PERIMETER ( a b -- P ) \ P = 2*(a+b)
+   \   a b -- a+b
2   \   a+b -- a+b 2
*   \   a+b 2 -- 2*(a+b)
;

: B3 ( a, b -- S P ) \ S = a*b, P = 2*(a+b)
2DUP        \   a b -- a b a b
PERIMETER   \   a b a b -- a b P
ROT         \   a b P -- b P a
ROT         \   b P a -- P a b
SQUARE      \   P a b -- P S
;

S" test/ttester.fs" included

t{ 2 3 B3 -> 10 6 }t
t{ 4 5 B3 -> 18 20 }t
t{ 2 0 B3 -> 4 0 }t
t{ 0 2 B3 -> 4 0 }t
