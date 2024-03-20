using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab4.Task2
{
    public class DisplayActionExtensions<TObjectType> : IDisplayable
    {
        public static void Print(TObjectType obj)
        {
            Console.WriteLine(obj?.ToString());
        }
        public static void Print(List<TObjectType> obj)
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
