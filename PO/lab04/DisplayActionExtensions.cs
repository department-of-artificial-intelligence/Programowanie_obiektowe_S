namespace lab04
{
    public static class DisplayActionExtensions
    {
        public static void Print<T>(this T obj)
        {
            Console.WriteLine(obj);
        }

        public static void Print<T>(this IList<T> list)
        {
            foreach (var item in list)
            {
                Print(item);
            }
        }
    }
}
