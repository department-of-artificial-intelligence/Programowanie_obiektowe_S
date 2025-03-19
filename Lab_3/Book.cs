namespace Lab_3
{
    public class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Autors { get; set; } = new List<Author>();
        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> autors)
            : base(id, title, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Autors = autors;
        }
        public void AddAuthor(Author autor)
        {
            Autors.Add(autor);
        }
        public override string ToString()
        {
            string authorsList = " ";
            foreach (var autor in Autors)
            {
                authorsList += autor.ToString();
            }
            authorsList += " ";
            return $"Item | {base.ToString()},PageCount{PageCount},Autors:{authorsList}"; // zrobic foreach
        }





        public override string GenerateBarCode()
        {
            Random rand = new Random();
            string result = "";
            for (int i = 0;i < 13; i++)
            {
                result += rand.Next(10);
            }
            return result; //póżniej zrób generator
        }
    }
}
