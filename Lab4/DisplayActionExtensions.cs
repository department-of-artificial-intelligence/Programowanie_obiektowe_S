using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class DisplayActionExtensions
    {
        public static void Print<TObjectType> (this TObjectType obj) where TObjectType: IDisplayable
        {
            if (obj != null) Console.WriteLine(obj.ToString());
        }

        public static void Print<TObjectType>(this IList<TObjectType> list) where TObjectType: IDisplayable 
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    if (item != null) Console.WriteLine(item.ToString());
                }
            } 
        }
    }
}