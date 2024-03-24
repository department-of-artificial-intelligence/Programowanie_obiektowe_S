using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PO.Lab4
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
        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            container.Set<TObjectType>()?.Add(obj);
            return container;
        }
        public static TObjectType Get<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var NewContainer = container.Set<TObjectType>();
            return NewContainer.First(searchPredicate);
        }
        public static void ForEach<TObjectType>(IList<TObjectType> list, Action<TObjectType> action)
        {
            foreach( var item in list)
            {
                action(item);
            }
        }
        public static IList<TObjectType> GetList<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            return container.Set<TObjectType>().Where(searchPredicate).ToList();
        }
        public static bool Remove<TObjectType>(this IContainer container, Func<TObjectType, bool> searchFn)
        {
            return container.Set<TObjectType>().Remove(container.Set<TObjectType>().FirstOrDefault(searchFn));
        }
        public static IContainer AddRange<TObjectType>(this IContainer container, IList<TObjectType> listOfElements)
        {
            for (int i = 0; i < listOfElements.Count(); i++)
            {
                container?.Set<TObjectType>()?.Add(listOfElements[i]);
            }
            return container;
        }

    }
}
