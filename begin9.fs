\ Begin9. Даны два неотрицательных числа a и b. 
\ Найти их среднее геометрическое, то есть квадратный корень из их произведения: a ⋅ b .

: B9 ( a b -- S ) \ S = SQRT(a*b)
F* FSQRT
;

S" test/ttester.fs" included

1e-5 abs-near f!  set-near

\ t{ 2E 1E B9 -> 1.414213562373E0 }t
