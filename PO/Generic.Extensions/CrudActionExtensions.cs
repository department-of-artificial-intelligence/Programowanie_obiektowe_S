using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generic.Extensions
{
    public static class CrudActionExtensions
    {
        public static IList<TObjectType> Set<TObjectType>(this IContainer containerObject)
        {
            var containerObjectType = containerObject.GetType();

            var propertyInfo = containerObjectType.GetProperties().FirstOrDefault(p => p.PropertyType == typeof(IList<TObjectType>));

            var value = propertyInfo?.GetValue(containerObject);

            return value as IList<TObjectType>;
        }
        public static void ForEach<TObjectType>(this IList<TObjectType> list, Action<TObjectType> action)
        {
            foreach (var item in list) { action(item); }
        }
        public static TObjectType Get<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var list = container?.Set<TObjectType>();
            try
            {
                return list.First(searchPredicate);
            }
            catch
            {
                Console.WriteLine("'Get' NOMATCHEXCEPTION caught");
            }
            return default;
        }
        public static TObjectType Get<TObjectType>(this IContainer container)
        {
            var list = container?.Set<TObjectType>();

            foreach (var item in list)
            {
                if (item != null)
                {
                    return item;
                }
            }
            return default;
        }
        public static IList<TObjectType>? GetList<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var list = container?.Set<TObjectType>();

            if (list == null)
            {
                return null;
            }
            List<TObjectType> neww = new List<TObjectType>();
            foreach (var item in list)
            {
                if (searchPredicate(item))
                {
                    neww.Add(item);
                }
            }
            if (neww.Count == 0)
            {
                Console.WriteLine("No items match the predicate");
                return null;
            }
            return neww;
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
        public static bool Remove<TObjectType>(this IContainer container, Func<TObjectType, bool> searchFN)
        {
            bool res = false;
            if (!container.Set<TObjectType>().Remove(container.Get(searchFN)))
            {
                res = true;
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