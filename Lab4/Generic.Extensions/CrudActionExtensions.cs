using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Extensions
{
    public static class CrudActionExtensions
    {
        public static IList<TObjectType>? Set<TObjectType>(this IContainer containerObject)
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

        public static TObjectType? Get<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate = null)
        {
            var containerList = container.Set<TObjectType>();
            if (containerList != null)
            {
                if (searchPredicate != null)
                {
                    return containerList.FirstOrDefault(searchPredicate);
                }
                else
                {
                    if (containerList.Count > 0)
                    {
                        return containerList[0];
                    }
                }
            }
            return default;
        }

        public static IList<TObjectType> GetList<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var List = container.Set<TObjectType>();
            if (searchPredicate != null && List != null)
            {
                return List.Where(searchPredicate).ToList();
            }
            else
            {
                return new List<TObjectType>();
            }
        }

        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            container.Set<TObjectType>()?.Add(obj);
            return container;
        }

        public static bool Remove<TObjectType>(this IContainer container, Func<TObjectType, bool> searchFn)
        {
            var list = container.Set<TObjectType>();
            var foundedElement = list.FirstOrDefault(searchFn);
            if (foundedElement != null)
            {
                list.Remove(foundedElement);
                return true;
            }
            else
            {
                return false;
            }

        }

        public static IContainer AddRange<TObjectType>(this IContainer container, IList<TObjectType> listOfElements)
        {
            var list = container.Set<TObjectType>();
            if (list != null)
            {
                foreach (var element in listOfElements)
                {
                    list.Add(element);
                }
            }
            return container;
        }
    }
}
