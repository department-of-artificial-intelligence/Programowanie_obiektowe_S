using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Item
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public DateTime DateOfIssue { get; set; }

        public Item() 
        {
			Title = "default title";
			Id = 0;
			Publisher = "default publisher";
			DateOfIssue = DateTime.Now;
        }

        public Item(string title, int id, string publisher, DateTime dateOfIssue) 
        {
			Title = title;
			Id = id;
			Publisher = publisher;
			DateOfIssue = dateOfIssue;
        }

		public override string ToString()
		{
            return $"Title: {Title}\nId: {Id}\nPublisher: {Publisher}\nDate of issue: {DateOfIssue}\n\n";
		}

        public void Details()
        {
            Console.WriteLine(ToString());
        }

        public virtual string GenerateBarCode() 
        {
            return "IBC";
        }
	}
}
