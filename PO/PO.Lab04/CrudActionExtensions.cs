namespace PO.Lab04
{
    internal static class CrudActionExtensions
    {
        public static IList<TObjectType>? Set<TObjectType>(this IContainer containerObject)
        {
            var containerObjectType = containerObject.GetType();
            var propertyInfo = containerObjectType.GetProperties().FirstOrDefault(
                p => p.PropertyType == typeof(IList<TObjectType>));

            if (propertyInfo != null)
            {
                var value = propertyInfo?.GetValue(containerObject);
                return value as IList<TObjectType>;
            }
            else
            {
                return new List<TObjectType>();
            }
        }

        public static void ForEach<TObjectType>(IList<TObjectType> list, Action<TObjectType> action)
        {
            foreach (var item in list)
            {
                action(item);
            }

        }

        public static TObjectType Get<TObjectType>(this IContainer container,
            Func<TObjectType, bool>? searchPredicate = null)
        {
            var containerObjectType = container.GetType();
            var propetyInfo = containerObjectType.GetProperties().FirstOrDefault(
                p => p.PropertyType == typeof(IList<TObjectType>));
            var value = propetyInfo?.GetValue(container);
            var list = value as IList<TObjectType>;
            if (list != null)
            {
                return searchPredicate != null ? list.FirstOrDefault(searchPredicate) : list.FirstOrDefault();
            }
            else
            {
                throw new InvalidOperationException("Container does not contain a list of specified type");
            }

        }

        public static IList<TObjectType> GetList<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var containerObjectType = container.GetType();
            var propertyInfo = containerObjectType.GetProperties().FirstOrDefault(
                p => p.PropertyType == typeof(IList<TObjectType>));
            var value = propertyInfo?.GetValue(container);
            var list = value as IList<TObjectType>;
            if (list != null)
            {
                return list.ToList();
            }
            else
            {
                throw new InvalidOperationException("Container does not contain a list of the specified type");
            }
        }

        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            var containerObjectType = container.GetType();
            var propertyInfo = containerObjectType.GetProperties().FirstOrDefault(
                p => p.PropertyType == typeof(IList<TObjectType>));
            var value = propertyInfo?.GetValue(container);
            var list = value as IList<TObjectType>;
            if (list == null)
                list = new List<TObjectType>();
            if (list != null)
            {
                list.Add(obj);
                propertyInfo.SetValue(container, list);
            }
            return container;
        }

        public static bool Remove<TObjectType>(this IContainer container, Func<TObjectType, bool> searchFn)
        {
            var containerObjectType = container.GetType();
            var propertyInfo = containerObjectType.GetProperties().FirstOrDefault(
                p => p.PropertyType == typeof(IList<TObjectType>));
            var value = propertyInfo?.GetValue(container);
            var list = value as IList<TObjectType>;
            if (list != null)
            {
                var itemsToRemove = list.Where(searchFn).ToList();
                foreach (var item in itemsToRemove)
                {
                    list.Remove(item);
                }
                propertyInfo.SetValue(container, list);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static IContainer AddRange<TObjectType>(this IContainer container, IList<TObjectType> listOfElement)
        {
            var containerObjectType = container.GetType();
            var propertyInfo = containerObjectType.GetProperties().FirstOrDefault(
                p => p.PropertyType == typeof(IList<TObjectType>));
            var value = propertyInfo?.GetValue(container);
            var list = new List<TObjectType>();

            if (list != null)
            {
                foreach (var element in listOfElement)
                {
                    list.Add(element);
                }
                propertyInfo.SetValue(container, list);
            }
            return container;
        }
    }


}