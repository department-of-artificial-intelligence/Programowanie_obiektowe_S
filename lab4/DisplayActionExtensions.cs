using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    static class DisplayActionExtensions
    {
        public static void Print<ToObjectType>(this ToObjectType obj) where ToObjectType: IDisplayable
        {
            if (obj != null) Console.WriteLine(obj.ToString());
        }
        public static void Print<ToObjectType>(this IList<ToObjectType> list) where ToObjectType : IDisplayable
        {
            if (list != null)
            {
                foreach (var l in list)
                {
                    l.Print();
                }
            }
        }
    }
}
