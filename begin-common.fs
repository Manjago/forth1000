: ALL_AR ( a b -- a+b, a-b, a*b, a/b )
2DUP ( a b a b )
+ ( a b a+b )
-ROT ( a+b a b )
2DUP ( a+b a b a b )
- ( a+b a b a-b )
-ROT ( a+b a-b a b )
2DUP ( a+b a-b a b a b )
* ( a+b a-b a b a*b )
-ROT ( a+b a-b a*b a b )
/ ( a+b a-b a*b a/b )
;

