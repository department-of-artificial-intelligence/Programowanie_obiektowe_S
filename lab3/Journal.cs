using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Journal : Item
    {
        
        public int Number {
            get;
            set;
        }

        public override string GenerateBarCode()
        {
            return $"Kodkreskowy";
        }

        public Journal() :base()
        {
           Number = 0 ;
        }

        public Journal(string title, int id, string publisher, DateTime DateOfIssue, int number) : base(title, id, publisher, DateOfIssue)
        {
            Number = 1;
            title = "Tytul z journal";
            id = 31;
            publisher = "Journalpublisher";
            DateOfIssue = DateTime.Now;

        }

        public override string ToString()
        {
            return $"Item | Id: {_id}, Autor: {_publisher}, Tytul: {_title}, Data_problemu {_dateOfIssue}";
        }




    }
}
