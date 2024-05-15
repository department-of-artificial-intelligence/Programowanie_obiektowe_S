namespace Lab8.BLL
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class SerializationIgnoreAttribute : Attribute
    {
    }
}