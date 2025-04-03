using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class CrudActionExtensions
    {
        public static IList<object> Set(IContainer containerObject) {}
        public static void ForEach(IList<object>, Action<object> action) {}
        public static object Get(IContainer container, Predicate<object> searchPredicate) {}
        public static IList<object> GetList(IContainer container, Predicate<object> searchPredicate) {}
        public static IContainer Add(IContainer container, object obj) {}
        public static bool Remove(IContainer container, Predicate<object> searchFn) {}
        public static IContainer AddRange(IContainer container, IList<object> listOfElements) {}
    }
}
