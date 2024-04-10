using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium.BLL
{
    public static class ExtensionMethods
    {
        public static void ForEach<TObjectType>(this IList<TObjectType> list, Action<TObjectType> func)
        {
            foreach (var item in list)
            {
                func(item);
            }
        }
        public static IList<TObjectType> AddRange<TObjectType>(this IList<TObjectType> list, IList<TObjectType> listOfElements)
        {
            if(listOfElements != null)
            {
                foreach (var item in listOfElements)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}