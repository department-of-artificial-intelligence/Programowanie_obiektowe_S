namespace PO.Lab04
{
    internal static class CrudActionExtensions
    {
        public static IList<TObjectType> Set<TObjectType>(this IContainer containerObject)
        {
            var containerObjectType = containerObject.GetType();
            var propertyInfo = containerObjectType.GetProperties().FirstOrDefault(p => p.PropertyType == typeof(IList<TObjectType>));

            var value = propertyInfo.GetValue(containerObject);
            return value as IList<TObjectType>;
        }

        public static void ForEach<TObjectType>(IList<TObjectType> list, Action<TObjectType> action)
        {
            foreach (var item in list)
            {
                action(item);
            }

        }

        public static TObjectType Get<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var list = container.Set<TObjectType>();

            return list.FirstOrDefault(searchPredicate);
        }

        public static IList<TObjectType> GetList<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var list = Set<TObjectType>(container);

            return list.Where(searchPredicate).ToList();
        }

        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            container.Set<TObjectType>().Add(obj);
            return container;
        }

        public static bool Remove<TObjectType>(this IContainer container, Func<TObjectType, bool> searchFn)
        {
            var list = Set<TObjectType>(container);
            var found = list.FirstOrDefault(searchFn);
            if (found != null)
            {
                list.Remove(found);
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
                foreach (var item in listOfElements)
                {
                    list.Add(item);
                }
            }
            return container;
        }


    }
}
