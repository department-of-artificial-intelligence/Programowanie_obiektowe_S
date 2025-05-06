using kol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kol
{
    static class Extension
    {
        public static void Dodaj(this SekcjaBanku sekcjaBanku, Pracownik pracownik)
        {
            sekcjaBanku.pracownicy.Add(pracownik);
        }
        public static void Wypisz(this Jednostka jednostka, Predicate<SekcjaBanku> predikat) 
        { 
            foreach (var FiliaBanku in SekcjaBanku.FiliaBanku)
            {
                foreach(var sekcja in FiliaBanku.sekcje)
                {
                    if (predikat(sekcja))
                    {
                        Console.WriteLine(&"Sekcja: {Jednostka.Nazwa}, liczba......");
                    }
                }
            }
        }
    }
}
