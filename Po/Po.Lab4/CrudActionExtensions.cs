using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab4
{
    internal static class CrudActionExtensions
    {
        public static IList<TObjectType> Set<TObjectType>(this IContainer containerObject)
        { 
            var containerObjectType = containerObject.GetType();
            var propertyInfo = containerObjectType.GetProperties().FirstOrDefault(
                p => p.PropertyType == typeof(IList<TObjectType>));
            var value = propertyInfo?.GetValue(containerObject);
            return value as IList<TObjectType>;
        }
        public static void ForEach<TObjectType>(this IList<TObjectType> list, Action<TObjectType> action)
        {
            foreach (var item in list)
            { 
                action(item);
            }
        }
        public static TObjectType Get<TObjectType>(this IContainer container, 
            Func<TObjectType, bool> searchPredicate)
        { 
            var containerObjectType = container.GetType();
            var propetyInfo = containerObjectType.GetProperties().FirstOrDefault(
                propa => propa.PropertyType == typeof(TObjectType)
                );
            var value = propetyInfo?.GetValue(container);
            var list = value as IList<TObjectType>;
            if (list != null)
            {
                return list.FirstOrDefault(searchPredicate);
            }
            else {
                throw new InvalidOperationException("Container does not contain a list of specified type");
            }

        }
    }
}
