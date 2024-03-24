using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab4.Task2
{
    public static class DisplayActionExtensions
    {
        public static void Print<TObjectType>(this TObjectType obj)
        {
            Console.WriteLine(obj?.ToString());
        }
        public static void Print<TObjectType>(this IList<TObjectType> obj)
        {
            if (obj == null)
                return;
            foreach (var item in obj)
            {
                Console.WriteLine(item?.ToString());
            }
        }
    }
}
