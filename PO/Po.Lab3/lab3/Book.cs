namespace lab3
{
    public class Book : Item
    {
        int PageCount { get; set; }
        IList<Author>? Authors { get; set; }

        Book
        public override string GenerateBarCode()
        {
            Random rnd = new Random();
            return (rnd.Next(100, 999)).ToString();
        }
    }
}
