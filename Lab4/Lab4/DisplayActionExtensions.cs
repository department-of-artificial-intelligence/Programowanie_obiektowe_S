using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class DisplayActionExtensions:IDisplayable
    {
        public void Print<T>(T obj)
        {
            Console.WriteLine(obj);
        }


        public void Print<T>(IList<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
