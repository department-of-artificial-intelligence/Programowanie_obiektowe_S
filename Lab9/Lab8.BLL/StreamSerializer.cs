using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public static class StreamSerializer
    {
        public static async Task Save<T>(this StreamWriter streamWriter, T obj)
        {
            Type objType = obj.GetType();
            await streamWriter.WriteLineAsync($"[[{objType.AssemblyQualifiedName}]]");
            foreach (var propertyInfo in objType.GetProperties())
            {
                //if (propertyInfo.GetCustomAttribute<TableAttribute>() == null)
                //{
                //    await streamWriter.WriteLineAsync($"[{propertyInfo.Name}]");
                //    await streamWriter.WriteLineAsync(propertyInfo.GetValue(obj)?.ToString());
                //}
            }
            await streamWriter.WriteLineAsync("[[TEST]]");
        }
    }
}
