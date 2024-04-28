using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
	public class SerializationIgnore : Attribute
	{
		public SerializationIgnore() { }
	}
	public static class StreamSerializer
	{
		public static async Task Save<T>(this StreamWriter streamWriter, T obj)
		{
			Type objType = obj.GetType();
			await streamWriter.WriteLineAsync($"[[{objType.AssemblyQualifiedName}]]");
			foreach (var propertyInfo in objType.GetProperties())
			{
				if (propertyInfo.GetCustomAttribute<SerializationIgnore>() == null)
				{
					await streamWriter.WriteLineAsync($"[{propertyInfo.Name}]");
					await streamWriter.WriteLineAsync(propertyInfo.GetValue(obj)?.ToString());
				}
			}
			await streamWriter.WriteLineAsync("[[]]");
		}
		public static async Task<T> Load<T>(this StreamReader streamReader) where T : new()
		{
			T obj = default(T);
			Type objType = null;
			PropertyInfo propertyInfo = null;
			while (!streamReader.EndOfStream)
			{
				var line = await streamReader.ReadLineAsync();
				if (line == "[[]]")
					return obj;

				else if (line != null && line.StartsWith($"[["))
				{
					objType = Type.GetType(line.Trim('[', ']'));
					if (typeof(T).IsAssignableFrom(objType))
						obj = (T)Activator.CreateInstance(objType);
				}
				else if (line != null && line.StartsWith("[") && obj != null)
					propertyInfo = objType?.GetProperty(line.Trim('[', ']'));
				else if (obj != null && propertyInfo != null)
					propertyInfo.SetValue(obj, Convert.ChangeType(line, propertyInfo.PropertyType));
			}
			return default(T);
		}
	}

}
