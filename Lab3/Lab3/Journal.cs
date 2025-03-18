using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Journal:Item
    {
        public int Number {  get; set; }
        public Journal() : base() 
        { 
            Number= 0;
        }
        public Journal(string title, int id, string publisher, DateTime doi,int number):base(title,id,publisher,doi)
        {
            Number = number;
        }

        public override string ToString()
        {
            return base.ToString()+$"NUMBER: {Number} ";
        }
        public override string GenerateBarCode()
        {
            return $" Journal:  ID: {Id} Number: {Number}";
        }













    }



}
