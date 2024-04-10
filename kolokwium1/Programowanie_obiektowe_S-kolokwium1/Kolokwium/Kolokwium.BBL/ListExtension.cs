namespace Kolokwium.BBL
{
    public static class ListExtension
    {
        public static void ForEach<T>(this IList<T> list, Action<T> callback)
        {
            foreach (var item in list)
            {
                callback(item);
            }
        }
        public static IList<T> AddRange<T>(this IList<T> list, IEnumerable<T> addition)
        {
            return list.AddRange(addition);
        }
    }
}
