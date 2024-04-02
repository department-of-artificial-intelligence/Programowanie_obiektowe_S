using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Przygotowanie_Full
{
    internal abstract class Item
    {

        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int Id { get { return _id; } set {  _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public DateTime DateOfIssue { get { return _dateOfIssue; } set { _dateOfIssue = value; } }

        public Item() { 
        
            _id = 0;
            _title = "none";
            _publisher = "none";
            _dateOfIssue = DateTime.Now;

        }

        public Item(string title, int id, string publisher, DateTime dateOfIssue) { 
        
            _title = title;
            _id = id;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
        
        }

        public override string ToString()
        {
            return $"Title {_title}, Id {_id}, Publisher {_publisher}, DateTime {_dateOfIssue}";
        }

        public void Details() {

            Console.WriteLine(ToString());

        }

        public string GenerateBarCode()
        {
            Random random = new Random();
            StringBuilder barcode = new StringBuilder();

            barcode.Append(random.Next(1, 10));

            for (int i = 1; i < 13; i++) {

                barcode.Append(random.Next(10));

            }

            return barcode.ToString();

        }


    }
}
