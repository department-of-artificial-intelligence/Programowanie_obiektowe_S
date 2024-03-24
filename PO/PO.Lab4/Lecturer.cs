using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab4
{
    public class Lecturer : Person
    { 
        public string AcademicTitle { get; set; }
        public string Position { get; set; }

        public Lecturer(string firstName, string lastName, DateTime dateOfBirth, string academictitle, string position)
            : base(firstName, lastName, dateOfBirth)
        {
            this.AcademicTitle = academictitle;
            this.Position = position;

        }
        public override string ToString()
        {
            Console.WriteLine($"AcademicTitle: {AcademicTitle}, Position: {Position}" + base.ToString());
            return "";
        }
    }
}
