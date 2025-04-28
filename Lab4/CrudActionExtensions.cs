using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
    /*
    public static class CrudActionExtensions
    {

        public static IList<T>? Set<T>(this IContainer container)
        {
            return container
                    .GetType()
                    .GetProperties()
                    .FirstOrDefault(property => property.PropertyType == typeof(IList<T>))
                    ?.GetValue(container) as IList<T>;
        }

        public static void ForEach<T>(this IList<T> list, Action<T> action)
        {
            list.ToList().ForEach(action);
        }

        public static T? Get<T>(this IContainer container, Func<T, bool> searchPredicate = null!)
        {
            IList<T>? list = container.Set<T>();

            if (searchPredicate is not null)
            {
                return (list is not null) ? list.FirstOrDefault(searchPredicate) : default;
            }
            else
            {
                return (list is not null) ? list.First() : default;
            }
        }

        public static IList<T>? GetList<T>(this IContainer container, Func<T, bool> searchPredicate)
        {
            IList<T>? list = container.Set<T>();
            return (list is not null) ? list.Where(searchPredicate).ToList() : default;
        }

        public static IContainer Add<T>(this IContainer container, T obj)
        {
            IList<T>? list = container.Set<T>();

            if (list is not null)
            {
                list.Add(obj);
            }

            return container;
        }

        public static bool Remove<T>(this IContainer container, Func<T, bool> searchPredicate)
        {
            IList<T>? list = container.Set<T>();

            if (list is not null)
            {
                T? obj = list.FirstOrDefault(searchPredicate);
                return (obj is not null) ? list.Remove(obj) : false;
            }

            return false;
        }

        public static IContainer AddRange<T>(this IContainer container, IList<T> listOfElements)
        {
            IList<T>? list = container.Set<T>();

            if (list is not null)
            {
                listOfElements.ToList().ForEach(element => container.Add(element));
            }

            return container;
        }

    }
}
    */
    public static class CrudActionExtensions
    {
        public static IList<TObjectType> Set<TObjectType>(this IContainer containerObject)
        {
            if (containerObject == null) return null!;
            var containerObjectType = containerObject?.GetType();
            if (containerObjectType == null) return null!;
            var propertyInfo = containerObjectType.GetProperties()
                .FirstOrDefault(p => p.PropertyType ==
                typeof(IList<TObjectType>));
            if (propertyInfo == null) return null!;
            var value = propertyInfo?.GetValue(containerObject);
            if (value == null) return null!;
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
                return list.FirstOrDefault(item => searchPredicate(item))!;
            else
                return default!;
        }
        public static IList<TObjectType> GetList<TObjectType>(this IContainer container, Predicate<TObjectType> searchPredicate)
        {
            var list = container.Set<TObjectType>();
            if (list == null)
                return null!;
            return list.Where(item => searchPredicate(item)).ToList();
        }

        //
        //Przeciążenie Get() bez predykatu
        public static TObjectType Get<TObjectType>(this IContainer container)
        {
            var list = container.Set<TObjectType>();

            return list.FirstOrDefault()!;
        }

        //Przeciążenie GetList() bez predykatu
        public static IList<TObjectType> GetList<TObjectType>(this IContainer container)
        {
            if (container == null) return null!;
            var list = container.Set<TObjectType>();
            if (list == null) return null!;
            return list.ToList();
        }
        //

        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            if (container == null) return null!;
            var list = container.Set<TObjectType>();
            if (list == null) return null!;

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
            if (container == null) return null!;
            var list = container.Set<TObjectType>();
            if (list == null) return null!;

            foreach (var element in listOfElements)
            {
                list.Add(element);
            }

            return container;
        }
    }
}