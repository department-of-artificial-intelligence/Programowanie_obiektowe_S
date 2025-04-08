using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public static class CrudActionExtension
    {
        public static IList<TObjectType> Set<TObjectType>(this IContainer containerObject)
        {
            var containerObjectType = containerObject.GetType();
            var propertyInfo = containerObjectType.GetProperties()
                .FirstOrDefault(
                p => p.PropertyType == typeof(IList<TObjectType>));
            var value = propertyInfo?.GetValue(containerObject);
            return value as IList<TObjectType>;
        }
        public static void ForEach<TObjectType>(this IList<TObjectType> list, Action<TObjectType> action)
        {
            foreach (var elem in list)
            {
                action(elem);
            }
        }

        public static TObjectType Get<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var list = container.Set<TObjectType>();

            if (list != null)
                return list.FirstOrDefault(elem => searchPredicate(elem));
            else
                return default;

        }

        public static TObjectType Get<TObjectType>(this IContainer container)
        {
            var list = container.Set<TObjectType>();
            return list.FirstOrDefault();
        }

        public static IList<TObjectType> GetList<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var list = container.Set<TObjectType>();
            if (list == null)
                return null;
            return list.Where(elem => searchPredicate(elem)).ToList();
        }
        public static IList<TObjectType> GetList<TObjectType>(this IContainer container)
        {
            var list = container.Set<TObjectType>();
            if (list == null)
                throw new InvalidOperationException($"Container does not contain a list for type {typeof(TObjectType).Name}");
            return list.ToList();
        }
        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            var list = container.Set<TObjectType>();

            if (list == null)
            {
                throw new InvalidOperationException($"Container does not contain a list for type {typeof(TObjectType).Name}");
            }

            list.Add(obj);
            return container;
        }

        public static bool Remove<TObjectType>(this IContainer container, Func<TObjectType, bool> searchFn)
        {
            var list = container.Set<TObjectType>();
            if (list == null)
                throw new InvalidOperationException($"Container does not contain a list for type {typeof(TObjectType).Name}");

            var elem = list.FirstOrDefault(x => searchFn(x));
            if (elem != null)
            {
                list.Remove(elem);
                return true;
            }
            return false;

        }

        public static IContainer AddRange<TObjectType>(this IContainer container, IList<TObjectType> listOfElements)
        {
            var list = container.Set<TObjectType>();
            if (list == null)
                throw new InvalidOperationException($"Container does not contain a list for type {typeof(TObjectType).Name}");

            foreach (var element in listOfElements)
            {
                list.Add(element);
            }

            return container;
        }
    }
}
