using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class CrudActionExtensions
    {
        //Set
        public static IList<TObjectType> Set<TObjectType>(this IContainer containerObject)
        {
            var containerObjectType = containerObject.GetType();
            var propertyInfo = containerObjectType.GetProperties()
                .FirstOrDefault(p => p.PropertyType ==
                typeof(IList<TObjectType>));
            var value = propertyInfo?.GetValue(containerObject);
            return value as IList<TObjectType>;
        }
        //ForEach
        public static void ForEach<TObjectType>(this IList<TObjectType> list, Action<TObjectType> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }
        //Get
        public static TObjectType Get<TObjectType>(this IContainer container, Predicate<TObjectType> searchPredicate)
        {
            var list = container.Set<TObjectType>();
            if (list != null)
                return list.FirstOrDefault(item => searchPredicate(item));
            else
                return default;
        }
        //GetList
        public static IList<TObjectType> GetList<TObjectType>(this IContainer container, Predicate<TObjectType> searchPredicate)
        {
            var list = container.Set<TObjectType>();
            if (list == null)
                throw new InvalidOperationException($"Container does not contain a list of type {typeof(TObjectType).Name}.");
            return list.Where(item => searchPredicate(item)).ToList();
        }

        //
        //Przeciążenie Get() bez predykatu
        public static TObjectType Get<TObjectType>(this IContainer container)
        {
            var list = container.Set<TObjectType>();
            return list.FirstOrDefault();
        }

        //Przeciążenie GetList() bez predykatu
        public static IList<TObjectType> GetList<TObjectType>(this IContainer container)
        {
            var list = container.Set<TObjectType>();
            if (list == null)
                throw new InvalidOperationException($"Container does not contain a list of type {typeof(TObjectType).Name}.");
            return list.ToList();
        }
        /* //Add można też tak zrobić:
        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            container.Set<TObjectType>()?.Add(obj);
            return container;
        }
        */

        //Add
        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            var list = container.Set<TObjectType>();
            if (list == null)
                throw new InvalidOperationException($"Container does not contain a list for type {typeof(TObjectType).Name}");

            list.Add(obj);
            return container;
        }

        //Remove
        public static bool Remove<TObjectType>(this IContainer container, Predicate<TObjectType> searchFn)
        {
            var list = container.Set<TObjectType>();
            if (list == null)
                throw new InvalidOperationException($"Container does not contain a list for type {typeof(TObjectType).Name}");

            var item = list.FirstOrDefault(x => searchFn(x));
            if (item != null)
            {
                list.Remove(item);
                return true;
            }

            return false;
        }
        //AddRange
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