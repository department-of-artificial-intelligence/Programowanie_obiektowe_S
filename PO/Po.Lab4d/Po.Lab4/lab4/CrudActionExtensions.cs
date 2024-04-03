namespace lab4
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

        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            container.Set<TObjectType>()?.Add(obj);
            return container;
        }

        public static IContainer AddRange<TObjectType>(this IContainer container, IList<TObjectType> listOfElements)
        {
            var containerList = container.Set<TObjectType>();
            if (containerList != null)
            {
                foreach (var element in listOfElements)
                {
                    containerList.Add(element);
                }
            }
            return container;
        }

        public static TObjectType Get<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate = null)
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
            throw new Exception("container is null");
        }

        public static IList<TObjectType> GetList<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var List = Set<TObjectType>(container);
            if (searchPredicate != null && List != null)
            {
                return List.Where(searchPredicate).ToList();
            }
            else
            {
                return new List<TObjectType>();
            }
        }

        public static bool Remove<TObjectType>(this IContainer container, Func<TObjectType, bool> searchFn)
        {
            var list = Set<TObjectType>(container);
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
    }
}
