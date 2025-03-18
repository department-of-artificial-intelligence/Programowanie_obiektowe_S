using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Journal
    {
        public int Number {  get; set; }
        public Journal()
        { 
            Number = 0;
        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
        {

        }
        public string ToString()
        {
            //return $"Id: {_id}, Title: {_title}, Publisher: {_publisher}, DateOfIssue: {_dateOfIssue}";
        }

        public string GenerateBarCode()
        
        {
                //13 losowych liczb jako string
                var chars = "0123456789";
                var output = new StringBuilder();
                var random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    output.Append(chars[random.Next(chars.Length)]);
                }
                return output.ToString();

        }
        
    }
}
