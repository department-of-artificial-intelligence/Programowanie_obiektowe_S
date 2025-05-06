.code
funkcja proc, x:ptr , a:ptr , b:ptr , c:ptr , d:ptr

fld b;
fld x;
call fxtoy
fld a;
fmul
fld c;
fld x;
call fxtoy;
fld b;
fmul
fsubp st(1), st(0);
fld c;
fld x;
fmul;
fadd;
fadd;
ret

jmp dalej;
fxtoy:
fyl2x
fld st;
frndint
fsub st(1), st
fxch st(1)
f2xm1
fld1
fadd
fscale
fstp st(1)
ret

dalej:

funkcja endp
end