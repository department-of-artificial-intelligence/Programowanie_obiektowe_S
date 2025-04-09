namespace Lab4
{
    public static class DisplayActionExtensions
    {
        public static void Print<T>(this T item) where T: IDisployable
        {
            Console.WriteLine(item.ToString());
        }
        public static void Print<T>(this IList<T> items) where T: IDisployable
        {
            string itemsString = string.Join(", ", items);
        }
    }
}
