using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    public static class CrudActionExtencions
    {

        public static IList<TObjectType> Set<TObjectType>(this IContainer containerObject)
        {
            var containerObjectType = containerObject.GetType();
            var propertyInfo = containerObjectType.GetProperties().FirstOrDefault(p => p.PropertyType == typeof(IList<TObjectType>));

            var value = propertyInfo?.GetValue(containerObject) as IList<TObjectType>;
            return value;
        }

        public static void ForEach<TObjectType>(this IList<TObjectType> list, Action<TObjectType> action)
        {
            foreach (var item in list) action(item);
        }


        public static IContainer Add<TObjectType, TItem>(this TObjectType containerObject, TItem obj)
        {
            // Sprawdzamy, czy containerObject nie jest null
            if (containerObject == null)
            {
                throw new ArgumentNullException(nameof(containerObject), "Container object cannot be null.");
            }

            // Szukamy właściwości typu IList<TItem>
            var propertyInfo = containerObject.GetType().GetProperties()
                .FirstOrDefault(p => p.PropertyType == typeof(IList<TItem>));

            // Jeśli nie ma odpowiedniej właściwości, zwracamy null
            if (propertyInfo == null)
            {
                return null;
            }

            // Pobieramy wartość tej właściwości (czyli listę)
            var value = propertyInfo.GetValue(containerObject);

            // Jeśli wartość jest typu IList<TItem>, dodajemy obiekt
            if (value is IList<TItem> list)
            {
                list.Add(obj);
            }
            else
            {
                // Jeśli lista jest null, możemy ją zainicjować
                value = new List<TItem>();
                propertyInfo.SetValue(containerObject, value);
                ((IList<TItem>)value).Add(obj);
            }

            // Zwracamy obiekt typu IContainer, jeśli jest
            return containerObject as IContainer;
        }


        public static IContainer AddRange<TObjectType, TItem>(this TObjectType containerObject, IList<TItem> items)
        {
            var propertyInfo = containerObject?.GetType().GetProperties()
                .FirstOrDefault(p => p.PropertyType == typeof(IList<TItem>));

            if (propertyInfo != null)
            {
                var value = propertyInfo.GetValue(containerObject);

                if (value is IList<TItem> list)
                {
                    foreach(var item in items)
                    {
                        list.Add(item);
                    }
                }
            }

            return containerObject as IContainer;
        }

        //var obtainedStudent = department2.Get<Student>(x => x.Group == 1); 


        //public static TObjectType Get<TObjectType, TContainer>(
        //this TContainer container,
        //Func<TObjectType, bool> searchPredicate)
        //{
        //    var containerType = container?.GetType();

        //    var listProperty = containerType.GetProperties()
        //        .FirstOrDefault(p => p.PropertyType == typeof(IList<TObjectType>));

        //    if (listProperty == null) return default;

        //    var list = listProperty.GetValue(container) as IList<TObjectType>;

        //    return list.FirstOrDefault(searchPredicate);
        //}

        public static TObjectType Get<TObjectType>(
        this Department department,
        Func<TObjectType, bool> searchPredicate)
        {
            if (department == null) return default;

            var containerType = department.GetType();

            var listProperty = containerType.GetProperties()
                .FirstOrDefault(p => p.PropertyType == typeof(IList<TObjectType>));

            if (listProperty == null) return default;

            var list = listProperty.GetValue(department) as IList<TObjectType>;

            if (list == null) return default;

            return list.FirstOrDefault(searchPredicate);
        }

        public static IList<TObjectType> Get<TObjectType>(
        this Department department)
        {
            if (department == null) return new List<TObjectType>();

            var containerType = department.GetType();

            var listProperty = containerType.GetProperties()
                .FirstOrDefault(p => p.PropertyType == typeof(IList<TObjectType>));

            if (listProperty == null) return new List<TObjectType>();

            var list = listProperty.GetValue(department) as IList<TObjectType>;

            if (list == null) return new List<TObjectType>();

            var filteredList = new List<TObjectType>();

            foreach (var item in list)
            {
                if (item != null) // Ignorujemy wartości null
                {
                    filteredList.Add(item);
                }
            }

            return filteredList;
        }

        //    public static IList<TObjectType> GetList<TContainer, TObjectType>(
        //this TContainer container,
        //Func<TObjectType, bool> searchPredicate) where TContainer : class
        //    {
        //        if (container == null) return new List<TObjectType>();

        //        var resultList = new List<TObjectType>();

        //        // Iterujemy po wszystkich właściwościach kontenera
        //        foreach (var property in container.GetType().GetProperties())
        //        {
        //            // Sprawdzamy, czy właściwość jest typu IList<TObjectType>
        //            if (property.PropertyType.IsGenericType &&
        //                property.PropertyType.GetGenericTypeDefinition() == typeof(IList<>))
        //            {
        //                // Uzyskujemy listę z właściwości kontenera
        //                var value = property.GetValue(container);

        //                // Jeśli lista jest typu IList<TObjectType>
        //                if (value is IList<TObjectType> list)
        //                {
        //                    // Dodajemy tylko te elementy, które spełniają warunki predykatu
        //                    foreach (var item in list)
        //                    {
        //                        if (searchPredicate(item))
        //                        {
        //                            resultList.Add(item);
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        return resultList;
        //    }


        public static IList<TObjectType> GetList<TObjectType>(
            this object container, 
            Func<TObjectType, bool> searchPredicate)
        {
            var resultList = new List<TObjectType>();
           
            if (container is IEnumerable enumerable)
            {
                foreach (var item in enumerable)
                {
                    
                    if (item is TObjectType typedItem)
                    {
                        bool predicateResult = searchPredicate(typedItem);
                        
                        if (predicateResult)
                        {
                            resultList.Add(typedItem);
                        }
                    }
                }
            }
            else
            {
                if (container is TObjectType singleItem)
                {
                    
                    bool predicateResult = searchPredicate(singleItem);

                    if (predicateResult)
                    {
                        resultList.Add(singleItem);
                    }
                }
            }

            return resultList;
        }

        public static void Remove<T>(this object container, Func<T, bool> removePredicate)
        {
            if (container == null)
                return;

            // Przechodzimy przez wszystkie właściwości obiektu
            foreach (var property in container.GetType().GetProperties())
            {
                // Sprawdzamy, czy właściwość jest typu List<T>
                if (property.PropertyType.IsGenericType &&
                    property.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    var value = property.GetValue(container);
                    if (value is IList<T> list)
                    {
                        // Usuwamy elementy, które pasują do predykatu
                        var itemsToRemove = list.Where(removePredicate).ToList();
                        foreach (var item in itemsToRemove)
                        {
                            list.Remove(item);
                        }
                    }
                }
            }
        }



    }
}
