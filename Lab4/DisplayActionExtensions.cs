using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    static public class DisplayActionExtensions
    {
        public static void Print<TObjectType>(this TObjectType obj)
        {
            PrintInternal(obj);  // Przekazanie obiektu do jednej wspólnej metody
        }

        // Metoda wyświetlająca listę obiektów
        public static void Print<TObjectType>(this IList<TObjectType> list)
        {
            foreach (var item in list)
            {
                PrintInternal(item);  // Przekazanie każdego elementu listy do wspólnej metody
            }
        }
        private static void PrintInternal<TObjectType>(TObjectType obj)
        {
            if (obj != null)
            {
                Console.WriteLine(obj.ToString());  // Wywołanie ToString na obiekcie
            }
            else
            {
                Console.WriteLine("Null object");
            }
        }
    }
}
