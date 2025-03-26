using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    interface IDisplayable
    {
        void Print<T>(T obj);
        void PrintList<T>(IList<T> list);
    }
}
