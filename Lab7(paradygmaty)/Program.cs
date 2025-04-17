using System;
using System.Diagnostics;
using Zad1;
using Zad2;
using Zad3;

class Program
{
    static void Main(string[] args)
    {
        //ZADANIE 1
        //Stopwatch stoper = new System.Diagnostics.Stopwatch();

        //stoper.Start();
        //int resultINT = 0;
        //for (int i = 0; i < 1000000000; i++)
        //{
        //    Para para = new Para(i, i+1);
        //    resultINT = para.Add();
        //}
        //stoper.Stop();
        //Console.WriteLine(stoper.ElapsedMilliseconds);

        //stoper.Restart();

        //stoper.Start();
        //for (int i = 0; i < 1000000000; i++)
        //{
        //    var para = new Para<int>{X = i, Y = i + 1};
        //    resultINT = para.Add();
        //}
        //stoper.Stop();
        //Console.WriteLine(stoper.ElapsedMilliseconds);

        //ZADANIE 2
        //Osoba osoba1 = new Osoba() { Imie = "Ala", Nazwisko = "Kot" };
        //Klasa<Osoba> klasa = new Klasa<Osoba>(osoba1);
        //Osoba osoba = klasa.Wartosc;
        //Console.WriteLine($"Imię: {osoba.Imie}, Nazwisko: {osoba.Nazwisko}");
        //Osoba nowaOsoba = klasa.NowaWartosc();
        //Console.WriteLine($"Nowa Osoba -> Imię: {nowaOsoba.Imie}, Nazwisko: {nowaOsoba.Nazwisko}");

        //ZADANIE 3
        var osoby = new List<Osoba>
        {
            new Osoba("Ala", "Kowalska", 25),
            new Osoba("Jan", "Nowak", 30),
            new Osoba("Zosia", "Zielinska", 22),
            new Osoba("Marek", "Wiśniewski", 28)
        };
        osoby.Sort();

        foreach (var osoba in osoby)
        {
            Console.WriteLine(osoba);
        }
    }
}