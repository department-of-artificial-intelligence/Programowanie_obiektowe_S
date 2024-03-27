#include <iostream>
#include <cmath>
using namespace std;



int main() {


	int a = 100;
	
	
	int y = 0;

	__asm {

	mov eax, a
	mov ebx, a
	neg eax
	cmovl eax, ebx
	mov y, eax

	}
	return y;
	system("PAUSE");
}