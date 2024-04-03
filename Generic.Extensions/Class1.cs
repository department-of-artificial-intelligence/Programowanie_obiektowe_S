using System.ComponentModel;
using System.Dynamic;



namespace Generic.Extensions
{
    public static class CrudActionExtensions
    {
        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            container.Set<TObjectType>()?.Add(obj);
            return container;
        }

        // metoda generyczna rozszerzająca typ IContainer
        public static IList<TObjectType> Set<TObjectType>(this IContainer containerObject)
        {
            var containerObjectType = containerObject.GetType();
            var propertyInfo = containerObjectType.GetProperties()
            .FirstOrDefault(p => p.PropertyType ==
             typeof(IList<TObjectType>));
            var value = propertyInfo?.GetValue(containerObject);
            return value as IList<TObjectType>;
        }

        public static void ForEach<TObjectType>(IList<TObjectType> list, Action<TObjectType> action) {

        }

        public static TObjectType Get<TObjectType>(IContainer container, Func<TObjectType, bool> searchPredicate)where TObjectType : class{
            // var containerObjectType = container.GetType();
            //   var propertyInfo = containerObjectType.GetProperties().FirstOrDefault(p=>p.PropertyType == typeof(TObjectType));
            //  var value = propertyInfo?.GetValue(containerObjectType);
            var value = container.Set<TObjectType>().FirstOrDefault(searchPredicate);
            return value;
        }
    }
}
