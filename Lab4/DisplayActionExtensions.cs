using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal static class DisplayActionExtensions
    {
        public static void Print<TObjectType>(this TObjectType obj) where TObjectType : IDisplayable
        {
            Console.WriteLine(obj.ToString());
        }

        public static void Print<TObjectType>(this IEnumerable<TObjectType> list) where TObjectType : IDisplayable
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
