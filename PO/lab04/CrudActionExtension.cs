namespace lab04
{
    public static class CrudActionExtension
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
        public static IContainer Add<T>(this IContainer container, T value)
        {
            container.Set<T>()?.Add(value);
            return container;
        }
        public static IContainer AddRange<T>(this IContainer container, IList<T> value)
        {
            var list = container.Set<T>();
            if (list != null)
            {
                foreach (var item in value)
                {
                    list.Add(item);
                }
            }
            return container;
        }
        public static T Get<T>(this IContainer container, Func<T, bool> fun)
        {
            return container.Set<T>().FirstOrDefault(fun);
        }
    }
}
