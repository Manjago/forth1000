\ Begin8. Даны два числа a и b. Найти их среднее арифметическое: (a + b)/2.

: B8 ( a b -- S ) \ S = (a + b)/2
F+ 2E F/ 
;

S" test/ttester.fs" included

1e-2 abs-near f!  set-near

t{ 2E 3E B8 -> 25E-1 }t