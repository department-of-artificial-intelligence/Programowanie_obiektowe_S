using System;

namespace Lab3.App
{
    public abstract class Item {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateofIssue;

        public int Id { get { return _id; } set { _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }

        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        
        public DateTime DateOfIssue { get { return _dateofIssue; } set { _dateofIssue = value; } }  

        public Item()
        {
            _id = 0;
            _title = "nie znany";
            _publisher = "nie znany";
            _dateofIssue = DateTime.MinValue;
        }
        public Item(int id, string title, string publisher, DateTime dateOfIssue)
        {
            _id = id;
            _title = title;
            _publisher = publisher;
            _dateofIssue = dateOfIssue;
            
        }

        public override string ToString()
        {
            return $"Item | ID: {_id}, Title: {_title}, Publisher:{_publisher}, DateOfIssue:{_dateofIssue}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string generateBarCode();
        

    }

    public class Journal : Item
    {
        public int Number
        {
            get; set;
        }

        public Journal()
        {

        }

        public Journal(string title, int id ,string publisher, DateTime dateOfIssue, int number): base(id,title, publisher, dateOfIssue)
        {
            Number = number;
        }

        public override string ToString()
        {
            return base.ToString()+$"Number:{Number}";
        }
        private static Random random = new Random();
        public override string generateBarCode()
        {
            
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int length = 13;
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }

    public class Catalog
    {
        IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog(IList<Item> items) 
        {
            Items = items;
        }
        public Catalog(string thematicDepartment,IList<Item> items)
        {
            ThematicDepartment = thematicDepartment;
            Items = items;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach(Item item in Items) {
            
            str += item.ToString();
            }
            return str+ ThematicDepartment;
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }


    }

    public class Book:Item
    {
        public int PageCount { get; set; }

        public IList<Author> Authors { get; set; }
        
        public Book(string title, int id, string publisher, DateTime dateOfIssue) { }
    }



}
