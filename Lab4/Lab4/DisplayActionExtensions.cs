using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class DisplayActionExtensions
    {
        public static void Print<T>(this T obj) where T:IDisplayable
        {
            if (obj == null)
            {
                Console.WriteLine("null"); 
            }
            else
            {
                Console.WriteLine(obj.ToString());
            }
        }
        public static void Print<T>(this IList<T> list) where T:IDisplayable
        {
            if (list == null) { Console.WriteLine("null"); }
            else
            {
                foreach (var item in list)
                {
                    if (item == null)
                    {
                        Console.WriteLine("null");
                            } 
                    else 
                    {
                        Console.WriteLine($"{item.ToString()}");
                    }
                }
            }
        }


    }
}
