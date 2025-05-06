using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Extensions {
	public static class DisplayActionExtensions {

		public static void Print<T>(this T obj) {
			Console.WriteLine(obj);
		}

		public static void Print<T>(this IList<T> list) {
			foreach (T obj in list) {
				obj.Print();
			}
		}

	}
}
