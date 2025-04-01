using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class CrudActionExtensions
    {
        //set
        //foreach
        public static object? Get(IContainer container, Predicate<object> searchPredicate)
        {
            foreach(var item in container.Components)
            {
                if (searchPredicate(item))
                {
                    return item;
                }
            }
            return null;
        }

        public static IList<object>? GetList(IContainer container, Predicate<object> searchPredicate)
        {
            IList<object> list = new List<object>();
            foreach(var item in container.Components)
            {
                if (searchPredicate(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public static IContainer Add(IContainer container, object? obj)
        {
            container.Add((IComponent?)obj);
            return container;
        }
        
        public static bool Remove(IContainer container, Predicate<object> searchFn) 
        {
            foreach (var item in container.Components)
            {
                if (searchFn(item))
                {
                    container.Remove((IComponent)item);
                    return true;
                }
            }
            return false;
        }    

        public static IContainer AddRange(IContainer container, IList<object> listOfElements) 
        { 
            foreach(object obj in listOfElements)
            {
                container.Add((IComponent)obj);
            }
            return container;
        }
        
    }
}
