using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class DisplayActionExtensions<TObjectType>:IDisplayable
    {
        public void Print(TObjectType obj) { }
        public void Print(IList<TObjectType> list) { }
    }
}
