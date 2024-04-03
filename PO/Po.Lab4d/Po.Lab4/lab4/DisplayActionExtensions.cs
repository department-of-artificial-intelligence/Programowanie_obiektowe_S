using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public static class DisplayActionExtensions
    { 

    public static void Print<TObjectType>(this IList<TObjectType> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }


    public static void Print<TObjectType>(this TObjectType obj)
        {
            Console.WriteLine(obj.ToString());
        }

    }
}
