using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    static class CrudActionExtensions
    {
        public static IList<ToObjectType> Set<ToObjectType>(this IContainer containerObject)
        {
            var containerObjectType = containerObject.GetType();
            var propertyInfo = containerObjectType.GetProperties().FirstOrDefault(p => p.PropertyType == typeof(IList<ToObjectType>));

            var value = propertyInfo?.GetValue(containerObject);
            return value as IList<ToObjectType>;
        }
        public static void ForEach<ToOBjectType>(this IList<ToOBjectType> list,Action<ToOBjectType> action)
        {
            foreach(var l in list)
            {
                action(l);
            }
        }
        public static ToOBjectType Get<ToOBjectType>(this IContainer container, Func<ToOBjectType,bool> searchPredicate) 
        {
            var list = container.Set<ToOBjectType>();
            if (list == null) return default;
            return list.FirstOrDefault(l => searchPredicate(l));
        }


        public static IList<ToOBjectType> GetList<ToOBjectType>(this IContainer container, Func<ToOBjectType, bool> searchPredicate)
        {
            var list = container.Set<ToOBjectType>();
            if (list == null) return null; ; ;
            return list.Where(l => searchPredicate(l)).ToList();
        }

        public static TObjectType Get<TObjectType>(this IContainer container)
        {
            var list = container.Set<TObjectType>();

            return list.FirstOrDefault();
        }

        public static IList<TObjectType> GetList<TObjectType>(this IContainer container)
        {
            if (container == null) return null;
            var list = container.Set<TObjectType>();
            if (list == null) return null;
            return list.ToList();
        }

        public static IContainer Add<ToOBjectType>(this IContainer container, ToOBjectType obj)
        {
            container.Set<ToOBjectType>()?.Add(obj);
            return container;
        }

        public static bool Remove<ToOBjectType>(this IContainer container, Func<ToOBjectType, bool> searchFn)
        {
            if (container == null) return false;
            var list = container.Set<ToOBjectType>();
            if (list == null) return false;

            var item = list.FirstOrDefault(l => searchFn(l));
            if (item == null) return false;
            list.Remove(item);
            return true;
        }


        public static IContainer AddRange<ToOBjectType>(this IContainer container, IList<ToOBjectType> listOfElements)
        {
            if (container == null) return null;
            var list = container.Set<ToOBjectType>();
            if (list == null) return null;
            foreach (var l in listOfElements)
            {
                list.Add(l);
            }
            return container;
        }


    }
}
