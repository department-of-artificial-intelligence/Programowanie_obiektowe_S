using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Journal:Item
    {
        public int Number
        {
              get; set;
        }


        public Journal():base() {
        }

        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(title, id, publisher, dateOfIssue) { 
            Number = number;
        }
        public override string ToString()
        {
            return $"id: {_id}, tytul: {_title}, wydawnictwo: {_publisher}, data wydania: {_dateOfIssue}, numer: {Number}.";
        }



        public override string GenerateBarCode() {

            string barcode = "";

            Random rand = new Random();

            for (int i = 0; i < 13; i++)
            {
                long liczba = rand.Next(0, 10);
                string liczba2 = liczba.ToString();
                barcode = barcode + liczba2;

            }

            return barcode;
        }

    }
}
