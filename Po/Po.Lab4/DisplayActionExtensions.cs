using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab4
{
    internal class DisplayActionExtensions
    {
        public void Print<TObjectType>(TObjectType obj)
        {
            Console.WriteLine(obj);
        }
        public void Print<TObjectType>(IList<TObjectType> list)
        {
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
