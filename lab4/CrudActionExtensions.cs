using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Extensions {
	public static class CrudActionExtensions {
		
		public static IList<T>? Set<T>(this IContainer container) {
			return container
					.GetType()
					.GetProperties()
					.FirstOrDefault(property => property.PropertyType == typeof(IList<T>))
					?.GetValue(container) as IList<T>;
		}

		public static void ForEach<T>(this IList<T> list, Action<T> action) {
			list.ToList().ForEach(action);
		}

		public static T? Get<T>(this IContainer container, Func<T, bool> searchPredicate = null) {
			IList<T>? list = container.Set<T>();

			if (searchPredicate is not null) {
				return (list is not null) ? list.FirstOrDefault(searchPredicate) : default;
			} else {
				return (list is not null) ? list.First() : default;
			}			
		}

		public static IList<T>? GetList<T>(this IContainer container, Func<T, bool> searchPredicate) {
			IList<T>? list = container.Set<T>();
			return (list is not null) ? list.Where(searchPredicate).ToList() : default;
		}

		public static IContainer Add<T>(this IContainer container, T obj) {
			IList<T>? list = container.Set<T>();

			if (list is not null) {
				list.Add(obj);
			}

			return container;
		}

		public static bool Remove<T>(this IContainer container, Func<T, bool> searchPredicate) {
			IList<T>? list = container.Set<T>();

			if (list is not null) {
				T? obj = list.FirstOrDefault(searchPredicate);
				return (obj is not null) ? list.Remove(obj) : false;
			}
			
			return false;					
		}

		public static IContainer AddRange<T>(this IContainer container, IList<T> listOfElements) {
			IList<T>? list = container.Set<T>();

			if (list is not null) {
				listOfElements.ToList().ForEach(element => container.Add(element));
			}

			return container;
		}

	}
}
