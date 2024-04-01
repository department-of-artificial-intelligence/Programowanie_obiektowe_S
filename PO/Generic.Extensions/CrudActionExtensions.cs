using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Extensions
{
    public static class CrudActionExtensions
    {
        public static IList<TObjectType> Set<TObjectType>(this IContainer containerObject)
        {
            var containerObjectType = containerObject.GetType();
            var propertyInfo = containerObjectType.GetProperties()
            .FirstOrDefault(p => p.PropertyType ==
             typeof(IList<TObjectType>));
            var value = propertyInfo?.GetValue(containerObject);
            return value as IList<TObjectType>;
        }
        public static void ForEach<TObjectType>(IList<TObjectType> list, Action<TObjectType> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }
        public static TObjectType Get<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var list = container?.Set<TObjectType>();
            if (list != null)
            {
                var result = list.FirstOrDefault(searchPredicate);
                if (result != null)
                {
                    return result;
                }
            }
            Console.WriteLine("'Get' NOMATCHEXCEPTION");
            return default;
        }
        public static IList<TObjectType> GetList<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            return container.Set<TObjectType>().Where(searchPredicate).ToList();
        }
        public static IList<TObjectType>? GetList<TObjectType>(this IContainer container)
        {
            var list = container?.Set<TObjectType>();

            if (list == null)
            {
                return null;
            }
            return list;
        }
        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            container.Set<TObjectType>()?.Add(obj);
            return container;
        }
        public static bool Remove<TObjectType>(this IContainer container, Func<TObjectType, bool> searchFn)
        {
            bool res = false;
            TObjectType objToRemove = container.Get(searchFn);
            if (objToRemove != null)
            {
                res = container.Set<TObjectType>().Remove(objToRemove);
            }
            return res;
        }
        public static IContainer AddRange<TObjectType>(this IContainer container, IList<TObjectType> listOfElements)
        {
            foreach (var item in listOfElements)
            {
                container?.Set<TObjectType>()?.Add(item);
            }
            return container;
        }
    }
}
