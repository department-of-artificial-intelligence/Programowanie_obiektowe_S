using System.Reflection;

namespace Lab4.App
{
    public static class CrudActionExtensions
    {
        public static IList<TObjectType> Set<TObjectType>(this IContainer containerObject)
        {
            
            Type containerObjectType = containerObject.GetType();
            PropertyInfo propertyInfo = containerObjectType.
                GetProperties().FirstOrDefault(p => p.PropertyType == typeof(IList<TObjectType>));
            var value = propertyInfo?.GetValue(containerObject);
            return value as IList<TObjectType>;
        }

        public static void ForEach<TObjectType>(this IList<TObjectType> list, Action<TObjectType> action)
        {
            foreach ( var item in list)
            {
                action(item);
            }
        }

        public static TObjectType Get<TObjectType>(this IContainer container, Func<TObjectType,bool> searchPredicate) { 
            var newcontainer = container.Set<TObjectType>();
            return newcontainer.First(searchPredicate);
        }

        public static IList<TObjectType> GetList<TObjectType>(this IContainer container, Func<TObjectType,bool> searchPredicate)
        {

            return container.Set<TObjectType>().Where(searchPredicate).ToList();
        }

        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            container.Set<TObjectType>()?.Add(obj);
            return container;
        }

        public static bool Remove<TObjectType>(this IContainer container, Func<TObjectType,bool> searchFN)
        {
            var cont = container.Set<TObjectType>();
            return cont.Remove(cont.First(searchFN));
        }
        public static IContainer AddRange<TObjectType>(this IContainer container
            , IList<TObjectType> list)
        {
            var cont = container.Set<TObjectType>();
            for (int i = 0; i < list.Count; i++)
                cont.Add(list[i]);
            return container;
        }


    }
}
