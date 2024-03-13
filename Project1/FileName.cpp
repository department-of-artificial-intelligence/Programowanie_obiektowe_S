#include <iostream>
#include <ctime>

using namespace std;

int rnd(const int min = 0, const int max = 100)
{
    return rand() % (max - min) + min;
};

int cppCase3(const int a, const int b, const int c, const int d, const int e, const int i)
{
    int y = 0;
    switch (i)
    {
    case 100:
    {
        y = a * b + c * d - e * i;
        break;
    }
    case 200:
    {
        y = ((- 1000 * i * i) - (500*a*b*c))/((d*e*i)+1);
        break;
    }
    default:
    {
        y = 42*a - 16*b + 8*c;
        break;
    }
    }
    return y;
}

int asmCase3(const int a, const int b, const int c, const int d, const int e, const int i)
{
    int y;
    __asm
    {
        mov eax, i
        cmp eax, 0
        jc _case0
        cmp eax, 1
        jc _case1


        _case0:
        mov eax, a
        imul eax, b
        mov ebx, c
        imul ebx, d
        mov ecx, e
        imul ecx, i
        add eax, ebx
        sub eax, ecx
         jmp _end

        _case1: 
        mov eax, i
        imul eax, i
        imul eax, -1000
        mov ebx, a
        imul ebx, b
        imul ebx, c
        imul ebx, 500
        mov ecx, d
        imul ecx, e
        imul ecx, i
        add ecx, 1
        sub eax, ebx
        cdq
        idiv ecx
        jmp _end



            _end:
        mov y, eax
    }
    return y;
}


int main()
{
    srand((unsigned)time(0));

    int a = rnd();
    int b = rnd();
    int c = rnd();
    int d = rnd();
    int e = rnd();

    cout << "a = " << a << endl;
    cout << "b = " << b << endl;
    cout << "c = " << c << endl;
    cout << "d = " << d << endl;
    cout << "e = " << e << endl;

    for (int i = 100; i <= 201; i += 100)
    {
        cout << "Operation: " << i << endl;
        cout << "[Cpp3]: " << cppCase3(a, b, c, d, e, i) << endl;
        cout << "[Asm3]: " << asmCase3(a, b, c, d, e, i) << endl;
    }

    return 0;
}