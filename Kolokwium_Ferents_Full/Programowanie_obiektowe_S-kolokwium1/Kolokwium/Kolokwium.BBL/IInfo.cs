namespace Kolokwium.BBL
{
    internal static class IInfo
    {

        public static void Display<TObjectType>(this TObjectType obj)
        {

            Console.WriteLine(obj?.ToString());

        }
    }
}
