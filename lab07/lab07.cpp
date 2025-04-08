// lab07.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
//extern "C"  __int64 size_asm(char* tab, int n);


	int size_cpp(char* tab)
	{
		int rozmiar = 0;
		while (tab[rozmiar++]);
		return --rozmiar;
	}
	int size_asm(char* tab, int n)
	{
		__asm {
			pushfd
			xor eax, eax; //eax <- 0 (NULL)
			mov edi, tab; //pocz¹tek tablicy
			mov ecx, n; //liczba elementów
			cld; //flaga kierunku danych
			repne scasb; //powtarzaj dopóki nierówne porównanie al i [edi]
			//(edi++, ecx--) tab[rozmiar]!=NULL;
			mov eax, n; //ponownie wielkoœæ tablicy
			sub eax, ecx; //(N - (N – (rozmiar +1)))
			dec eax; //(rozmiar + 1 -1)
			popfd
		}
	}
	int find_cpp(char* tab, char znak)
	{
		int n = 0, poz;
		while (tab[n])
			if (tab[n++] == znak)
			{
				poz = n;
				break;
			}
		return --poz;
	}
	int find_asm(char* tab, int n, char znak)
	{
		int poz;
		__asm {
			pushfd;
			xor eax, eax;
			mov al, znak; //eax <- 0 (NULL)
			mov edi, tab; //pocz¹tek tablicy
			mov ecx, n; //liczba elementów
			cld; //kasowanie flagi kierunku. Ustaw (std) flagê (df) edi++
			repne scasb; //powtarzaj dopóki nierówne porównanie al i [edi]
			//(edi++, ecx--) tab[rozmiar]!=NULL;
			mov eax, n; //ponownie wielkoœæ tablicy
			sub eax, ecx; //(N - (N – (rozmiar + 1)))
			dec eax; //(rozmiar + 1 -1)
			mov poz, eax;
			popfd;
		}
		return poz;
	}


	char* r_trim_cpp(char* tab)
	{
		int N = size_cpp(tab);
		N--;
		while (tab[N])
		{
			if (tab[N] != ' ') //znajdŸ pierwszy znak ró¿ny od spacji
			{
				N++;
				tab[N] = '\0';
				break;
			}
			N--;
		}
		return tab;
	}

	char* r_trim_asm(char* tab, int n)
	{
		__asm
		{
			pushfd
			xor eax, eax;
			mov edi, tab;
			mov ecx, n; //liczba elementów (max)
			cld; //flaga kierunku danych
			repne scasb; //powtarzaj dopóki nierówne porównanie al i [edi]
			sub edi, 2; //ostatni element tekstu
			std;
			mov ecx, n;
			mov al, 32;
			repe scasb;
			add edi, 2;
			mov[edi], 00h;
			popfd;
		}
		return tab;
	}


	char* copy_cpp(char* tab, char* tab2)
	{
		int N = size_cpp(tab);
		for (size_t i = 0; i < N; i++)
		{
			tab2[i] = tab[i];
		}
		return tab2;
	}

	char* copy_asm(char* tab, char* tab2, int n)
	{
		__asm 
		{
			pushfd
			xor eax, eax; //zerowanie
			mov esi, tab; //adres tablicy do esi
			mov edi, tab2; // adres drugiej tablicy do edi
			mov ecx, n; // rozmiar tablicy do ecx
			cld; //flage se czyszcze
			rep movsb; // jak nie zjebalem to kopiuje
			mov[edi], 00h; 


		}
	}


	int main()
	{
		const int n = 100;
		int start = 2;
		int ile = 7;
		char tab[n] = "Ala ma kota   ";
		char tab2[n] = "";
		char tab3[n] = "";
		cout << "size_cpp " << size_cpp(tab) << endl;
		cout << "size_asm " << size_asm(tab, n) << endl << endl;
		cout << "find_cpp " << find_cpp(tab, 'k') << endl;
		cout << "find_asm " << find_asm(tab, n, 'k') << endl << endl;
		cout << "[" << tab << "]" << endl;
		cout << "r_trim_cpp [" << r_trim_cpp(tab) << "]" << endl << endl;
		memcpy(tab, "Ala ma kota ", 32);
		cout << "[" << tab << "]" << endl;
		cout << "r_trim_asm [" << r_trim_asm(tab, n) << "]" << endl << endl;
		memcpy(tab, "Ala ma kota ", 32);
		cout << "TEst:: [" << copy_cpp(tab, tab2) << "]" << endl << endl;
		cout << "[" << tab2 << "]" << endl;
		//cout << "substr_cpp [" << substr_asm(tab, tab2, start, ile) << "]" << endl;
		cout << "TEst:: [" << copy_asm(tab, tab3, n) << "]" << endl << endl;
		cout << "[" << tab3 << "]" << endl;
		//cout << "substr_asm [" << substr_asm(tab, tab2, start, ile) << "]" << endl << endl;
		system("PAUSE");

		return 0;

	}




