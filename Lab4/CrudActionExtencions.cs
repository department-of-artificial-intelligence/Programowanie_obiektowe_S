using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class CrudActionExtencions<TObjectType>:IContainer, IDisplayable
    {
        public IList<TObjectType> Set(IContainer containerObject)
        {
            
        }
        public void ForEach(IList<TObjectType> list, Action<TObjectType> action)
        {

        }
        public TObjectType Get(IContainer container, Func<TObjectType, bool> seachPredicate)
        {

        }
        public IList<TObjectType> GetList(IContainer container, Func<TObjectType, bool> predicate)
        {

        }
        public IContainer Add(IContainer container, TObjectType obj)
        {

        }
        public bool Remove(IContainer container, Func<TObjectType, bool> searchFn)
        {

        }
        public IContainer AddRange(IContainer container, IList<TObjectType> listOfElements)
        {

        }

    }
}
