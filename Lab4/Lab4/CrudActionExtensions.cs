using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class CrudActionExtensions
    {
        public static IList<T> Set<T>(this IContainer obj)
        {
            var containerObjectType= obj.GetType();
            var propertyInfo = containerObjectType.GetProperties()
                .FirstOrDefault(p => p.PropertyType == typeof(IList<T>));
            var value=propertyInfo?.GetValue(obj) as IList<T>;
            return value;
        }    
        public static void ForEach<T>(this IList<T> list, Action<T> action)
        {
            foreach ( var item in list) action(item);
        }

        public static T? Get<T>(this IContainer obj, Func<T, bool>? searchPredicate = null)
        {
            var list = obj.Set<T>();
           // var list1 = Set<T>(obj);
            if (list == null || list.Count == 0) return default;

            return searchPredicate == null ? list.FirstOrDefault(): list.FirstOrDefault(searchPredicate);
        }

        public static IList<T> GetList<T>(this IContainer obj, Func<T, bool>? searchPredicate = null)
        {
            var list = obj.Set<T>() ?? new List<T>();

            return searchPredicate == null ? list: list.Where(searchPredicate).ToList();
        }
        public static IContainer Add<T>(this IContainer obj, T objToAdd)
        {
            obj.Set<T>().Add(objToAdd);
            return obj;
        }
        public static bool Remove<T>(this IContainer obj, Func<T, bool> searchPredicate)
        {
            var list = obj.Set<T>();
            if (list == null || list.Count == 0) return false;

            var itemsToRemove = list.Where(searchPredicate).ToList();

            if (itemsToRemove.Count == 0) return false;

            foreach (var item in itemsToRemove)
            {
                list.Remove(item);
            }

            return true;
        }
        public static IContainer AddRange<T>(this IContainer obj, IList<T> listOfElements)
        {
            var list = obj.Set<T>();
            if (list == null) return obj;

            foreach (var item in listOfElements)
            {
                list.Add(item);
            }

            return obj;
        }

    }
}
