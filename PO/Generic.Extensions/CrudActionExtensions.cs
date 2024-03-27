using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
        public static void ForEach<TObjectType>(IList<TObjectType> list
            , Action<TObjectType> action)
        {
            foreach ( var item in list )
            {
                action(item);
            }
        }
        public static TObjectType Get<TObjectType>(this IContainer container
            ,Func<TObjectType,bool> seachPredicate)
        {
            var cont = container.Set<TObjectType>();
            var val = cont.First(seachPredicate);
            return val;
        }
        public static IList<TObjectType> GetList<TObjectType>(this IContainer container
            , Func<TObjectType, bool> seachPredicate)
        {
            return container.Set<TObjectType>().Where(seachPredicate).ToList();
        }
        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            container.Set<TObjectType>()?.Add(obj);
            return container;
        }
        public static bool Remove<TObjectType>(this IContainer container
            ,Func<TObjectType,bool> seachFn)
        {
            var cont = container.Set<TObjectType>();
            return cont.Remove(cont.First(seachFn));
        }
        public static IContainer AddRange<TObjectType>(this IContainer container
            ,IList<TObjectType> list)
        {
            var cont = container.Set<TObjectType>();
            for (int i = 0;i<list.Count;i++)
                cont.Add(list[i]);
            return container;
        }
    }
}
