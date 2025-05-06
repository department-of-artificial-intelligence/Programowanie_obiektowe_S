

#include <iostream>

using namespace std;

extern "C" float funkcja(float *x, float *a, float *b, float *c, float *d);

int main()
{
    float x = 2.0;
    float a = 2.0;
    float b = 2.0;
    float c = 2.0;
    float d = 2.0;
    float y = funkcja(&x, &a, &b, &c, &d);
    cout << "Y = " << y;
}


