using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Journal : Item
    {
        public int Number { get; set; }
        public Journal()
        {
            Number = 0;
        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(title, id, publisher, dateOfIssue){
            Number = number;

        }

        public override string ToString()
        {
            //return base.ToString()+$" number {Number}" //zamiast tego opcja na dole ponieważ konkatenacja zawsze zżera resource
            return $"{base.ToString()}, number {Number}";
        }

        public override string GenerateBarCode()
        {
            return "testBarcode";  //Stwórz prawidłowy 8 znaków
        }
    }
}
