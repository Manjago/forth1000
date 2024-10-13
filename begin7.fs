\ Begin7°. Найти длину окружности L и площадь круга S заданного радиуса R:
\ L = 2·π·R,
\ S = π·R^2 .
\ В качестве значения π использовать 3.14.

: L ( R -- 2·π·R ) \ L = 2·π·R
314E-2 F* 2E0 F*
;

: S ( R -- π·R^2 ) \ S = π·R^2
FDUP F* 314E-2 F*
;

: B7 ( R -- L S ) \ L = 2*3.14*R, S = 3.14*R^2
FDUP ( R R )
L ( R L )
FSWAP ( L R )
S ( L S )
;

S" test/ttester.fs" included

t{ 2E L -> 1256E-2 }t
t{ 3E S -> 2826E-2 }t

1e-2 abs-near f!  set-near
t{ 5E B7 -> 314E-1 785E-1 }t
