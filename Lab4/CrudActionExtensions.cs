namespace Lab4
{
    public static class CrudActionExtensions
    {
        public static IList<T> Set<T>(this IContainer containerObject)
        {
            var containerObjectType = containerObject.GetType();
            var propertyInfo = containerObjectType.GetProperties()
                .FirstOrDefault(p => p.PropertyType ==
                typeof(IList<T>));
            var value = propertyInfo?.GetValue(containerObject);
            return value as IList<T>;
        }
    }
}
