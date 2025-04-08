using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab4 {
    internal static class CrudActionExensions {
        public static IList<T>? Set<T>(this IContainer containerObject) =>
             containerObject.GetType()
                            .GetProperties()
                            ?.FirstOrDefault(property => property.PropertyType == typeof(IList<T>))
                            ?.GetValue(containerObject) as IList<T>;
        
        public static void ForEach<T>(this IList<T> list, Action<T> action) {
            list.ToList().ForEach(action);
            
        }
        public static T? Get<T>(this IContainer container, Func<T, bool> funcSearch) {
            IList<T>? list = container.Set<T>();
            return (list is null) ? default : list.FirstOrDefault(funcSearch);
        }
        public static IList<T>? GetList<T>(this IContainer container, Func<T, bool> funcSearch) {
            IList<T>? list = container.Set<T>();
            return (list is null) ? default : list.Where(funcSearch).ToList();
        }

    }
}
