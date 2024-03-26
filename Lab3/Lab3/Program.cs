using System.Security.AccessControl;

namespace Lab3
{
    public abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int Id
        {
            get => _id; 
            set => _id = value;
        }
        public string Title 
        {
            get => _title;
            set => _title = value;
        }
        public string Publisher 
        {
            get => _publisher;
            set => _publisher = value;
        }
        public DateTime DateOfIssue 
        {
            get => _dateOfIssue; 
            set => _dateOfIssue = value;
        }

        public Item() 
        {
            _id = 0;
            _title = "Default";
            _publisher = "Default";
            _dateOfIssue = DateTime.MinValue;
        }

        public Item(int _id, string _title, string _publisher, DateTime _dateOfIssue)
        {
            Id = _id;
            Title = _title;
            Publisher = _publisher;
            DateOfIssue = _dateOfIssue;
        }

        public override string ToString()
        {
            return $"Id: {_id} Nazwa: {_title} Autor: {_publisher} Rok: {_dateOfIssue}";
        }

        public virtual void Details()
        {
            Console.WriteLine(ToString() );
        }

        public abstract string GenerateBarCode();
    }

    public class Catalog
    {

    }

    public class Journal
    {
        public IList<Item> Items { get; set; }
        public int Number { get; set; }
        public Journal()
        {
            Number = 0;
        }
        public Journal(string title, int id,  string publisher, DateTime dateOfIssue, int number)
        {

        }
    }

    public class Book
    {

    }

    public class Author
    {

    }
}
