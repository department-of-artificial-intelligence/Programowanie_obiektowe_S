namespace Lab_3
{
    public class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Autor> Autors { get; set; } = new List<Autor>();
        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Autor> autors)
            : base(id, title, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Autors = autors;
        }
        public void AddAuthor(Autor autor)
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
            return "test"; //póżniej zrób generator
        }
    }
}
