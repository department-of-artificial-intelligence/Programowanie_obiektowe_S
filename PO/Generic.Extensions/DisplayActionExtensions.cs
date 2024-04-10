namespace Generic.Extensions
{
    public static class DisplayActionExtensions
    {
        public static void Print<TObjectType>(this TObjectType obj)
        {
            Console.WriteLine(obj?.ToString());
        }
        public static void Print<TObjectType>(this IList<TObjectType> list){
            if(list != null) {
            foreach(var item  in list)
                {
                    Console.WriteLine(item?.ToString());
                }
            }
        }

    }
}
