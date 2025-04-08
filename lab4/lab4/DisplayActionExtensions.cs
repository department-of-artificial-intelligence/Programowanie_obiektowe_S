using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public static class DisplayActionExtensions
    {
        public static void Print<TObjectType>(this TObjectType obj) where TObjectType : IDisplayable
        {
            Console.WriteLine(obj.ToString());
        }
        public static void Print<TObjectType>(this IList<TObjectType> list) where TObjectType : IDisplayable
        {
            foreach (var elem in list)
            {
                Console.WriteLine(elem.ToString());
            }
        }
    }
}
