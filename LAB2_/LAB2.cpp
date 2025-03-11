#include <iostream>
using namespace std;
int main()
{
    unsigned short g = 23;
    unsigned short gg = 0;
    __asm{
        xor eax, eax;
        mov ax, g;
        inc ax;
        mov ebx, eax;
        mov gg, bx;
    }
    cout << g << " " << gg << endl;
    return 0;
}


