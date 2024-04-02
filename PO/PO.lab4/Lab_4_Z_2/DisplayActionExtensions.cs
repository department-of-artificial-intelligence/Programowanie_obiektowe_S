using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Przygotowanie
{
    internal static class DisplayActionExtensions
    {

        public static void Print<TObjectType>(this TObjectType obj) {

            Console.WriteLine(obj?.ToString());

        }

        public static void Print<TObjectType>(this IList<TObjectType> list) { 
        
            foreach (var item in list) {

                if (list != null) {

                    Console.WriteLine(item?.ToString());
                }

            }
        
        }


    }
}
