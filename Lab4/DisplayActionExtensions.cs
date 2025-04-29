namespace Lab4
{
    public static class DisplayActionExtensions
    {

        public static void Print<T>(this T obj)
        {
            Console.WriteLine(obj);
        }

        public static void Print<T>(this IList<T> list)
        {
            foreach (T obj in list)
            {
                obj.Print();
            }
        }

    }
}