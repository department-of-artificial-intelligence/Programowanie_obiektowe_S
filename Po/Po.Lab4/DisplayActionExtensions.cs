using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab4
{
    public static class DisplayActionExtensions
    {
        public static void Print<TObjectType>(this TObjectType obj)
        {
            Console.WriteLine(obj);
        }
        public static void Print<TObjectType>(this IList<TObjectType> list)
        {
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
