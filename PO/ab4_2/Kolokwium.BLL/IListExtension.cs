using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public static class IListExtension
    {
        public static TObjectType Delete<TObjectType>(this IList<TObjectType> list, Func<TObjectType, bool> predicate)
        {
            foreach(TObjectType obj in list)
            {
                if(predicate(obj))
                {
                    list.Remove(obj);
                    return obj;
                }
            }
            throw new Exception("Searched object doesn't exist.");
        }
        public static void UpdateRange<TObjectType>(this IList<TObjectType> list,Func<TObjectType, bool> predicate, TObjectType newObj)
        {
            int size = 0;
            foreach(TObjectType obj in list) 
            {
                size++;
            }
            for(int i =0; i< size; i++)
            {
                if (predicate(list[i]))
                {
                    list[i] = newObj;
                }
            }
            
        }
    }
}
