
#include <iostream>

using namespace std;

float kolo(float r) {

    float y;
    float abcd = 4/3;
    __asm {

        fld r;  // r
        fld r;  // r, r
        fmul; //rr
        fld r;  // r, rr
        fmul st, st(1);  //rrr
        fldpi; // 3.14, rrr
        fmul st(1), st; //3,14rrr
        fld abcd; // 1.333, 3,14rrr
        fmul st, st(1); //wynik
        fstp y;

    }
    return y;

}

float pkuli(float r) {

    float y;
    float abcd = 4.0f;

    __asm {

        fld r;  // r
        fld r;  // r, r
        fmul; //rr
        fldpi; // 3.14, rr
        fmul st(1), st; //3,14rr
        fld abcd; // 4, 3,14rr
        fmul; //wynik
        fstp y;

    }
    return y;
}

int main()
{
    float g = kolo(1);
    cout << g << "\n";

    float k = pkuli(1);
    cout << k << "\n";

}


