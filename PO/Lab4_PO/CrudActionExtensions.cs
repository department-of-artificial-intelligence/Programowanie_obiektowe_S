using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_PO
{
    public class CrudActionExtensions
    {
        public static IList<TObjectType>? Set <TObjectType>(IContainer containerObject)
        {
            var containerObjectType = containerObject.GetType();
            var propertyInfo = containerObjectType.GetProperties()
                                                            .FirstOrDefault(p => p.PropertyType ==
                                                                            typeof(IList<TObjectType>));
            var value = propertyInfo?.GetValue(containerObject);
            return value as IList<TObjectType>;
        }

        public static void ForEach<TObjectType>(IList<TObjectType> list, Action <TObjectType> action)
        {
            foreach ( var item in list)
            {
                action(item);
            }
        }

        public static TObjectType Get<TObjectType>(IContainer container, Func<TObjectType, bool> searchPredicate = null)
        {
            var containerObjectType = container.GetType();
            if (searchPredicate == null)

         
        }
    }
}
