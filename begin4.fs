\ Begin4. Дан диаметр окружности d. Найти ее длину L = π·d. В качестве значения π использовать 3.14

: B4 ( da -- L ) \ L = π·d, π = 3.14
3.14E
F*
;

S" test/ttester.fs" included

t{ 2E B4 -> 6.28E }t
t{ 3E B4 -> 9.42E }t
t{ 0E B4 -> 0E }t
