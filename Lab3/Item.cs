using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal abstract class Item
    {
        protected int _id;
        protected string? _title;
        protected string? _publisher;
        protected DateTime _dateOfIssue;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Title
            { get { return _title!; } set { _title = value; } }
        public string Publisher
            { get { return _publisher!; } set {_publisher = value; } }
        public DateTime DateOfIssue 
            { get { return _dateOfIssue; } set {_dateOfIssue = value; } }

        public Item()
        {
            Id = 0;
            Title = "Unknown";
            Publisher = "Unknown";
            DateOfIssue = DateTime.MinValue;
            
        }

        public Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            Id = id;
            Title = title;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;

        }

        public override string ToString() 
        { 
            return $"Id={Id},Title={Title},Publisher={Publisher},DateOfIssue={DateOfIssue}"; 
        }

        public void Details()
        {
          Console.WriteLine(this);
        }

        public abstract string GenerateBarCode();
        


    }
}
