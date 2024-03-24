using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab4
{
    public static class DisplayActionExtensions
    {
        public static void Print<TObjectType>(this TObjectType obj)
        {
            Console.WriteLine(obj?.ToString());
        }
        public static void Print<TObjectType>(this IList<TObjectType> list)
        {
            if(list != null) { 
            foreach (TObjectType obj in list)
            {
                Console.WriteLine(obj?.ToString());
            }
            }
        }

    }
}
