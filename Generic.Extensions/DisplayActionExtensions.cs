using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Extensions
{
    static public class DisplayActionExtensions
    {
        public static void Print<TObjectType>(this TObjectType obj)
        {
            PrintInternal(obj);  
        }

        
        public static void Print<TObjectType>(this IList<TObjectType> list)
        {
            foreach (var item in list)
            {
                PrintInternal(item);  
            }
        }
        private static void PrintInternal<TObjectType>(TObjectType obj)
        {
            if (obj != null)
            {
                Console.WriteLine(obj.ToString());
            }
            else
            {
                Console.WriteLine("Null object");
            }
        }
    }
}
