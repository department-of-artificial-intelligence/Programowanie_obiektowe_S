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
        public static IList<TObjectType> Set<TObjectType>(this IContainer containerObject)
        {
            if (containerObject == null) return null;
            var containerObjectType = containerObject?.GetType();
            if (containerObjectType == null) return null;
            var propertyInfo = containerObjectType.GetProperties()
                .FirstOrDefault(p => p.PropertyType ==
                typeof(IList<TObjectType>));
            if (propertyInfo == null) return null;
            var value = propertyInfo?.GetValue(containerObject);
            if (value == null) return null;
            return value as IList<TObjectType>;
        }
        public static void ForEach<TObjectType>(this IList<TObjectType> list, Action<TObjectType> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }
        public static TObjectType Get<TObjectType>(this IContainer container, Predicate<TObjectType> searchPredicate)
        {
            var list = container.Set<TObjectType>();
            if (list != null)
                return list.FirstOrDefault(item => searchPredicate(item));
            else
                return default;
        }
        public static IList<TObjectType> GetList<TObjectType>(this IContainer container, Predicate<TObjectType> searchPredicate)
        {
            var list = container.Set<TObjectType>();
            if (list == null)
                return null;
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
            if (container == null) return null;
            var list = container.Set<TObjectType>();
            if (list == null) return null;
            return list.ToList();
        }
        //

        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            if (container == null) return null;
            var list = container.Set<TObjectType>();
            if (list == null) return null;

            list.Add(obj);
            return container;
        }
        public static bool Remove<TObjectType>(this IContainer container, Predicate<TObjectType> searchFn)
        {
            if (container == null) return false;
            var list = container.Set<TObjectType>();
            if (list == null) return false;

            var item = list.FirstOrDefault(x => searchFn(x));
            if (item != null)
            {
                list.Remove(item);
                return true;
            }

            return false;
        }
        public static IContainer AddRange<TObjectType>(this IContainer container, IList<TObjectType> listOfElements)
        {
            if (container == null) return null;
            var list = container.Set<TObjectType>();
            if (list == null) return null;

            foreach (var element in listOfElements)
            {
                list.Add(element);
            }

            return container;
        }
    }
}