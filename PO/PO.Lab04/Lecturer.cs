using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab04
{
    internal class Lecturer : Person
    {
        

        public string AcademicTitle { get; set; }
        public string Position { get; set; }

        public Lecturer(string firstName, string lastName, DateTime dateOfBirth, string academicTitle, string positin) : base(firstName, lastName, dateOfBirth)
        {
            AcademicTitle = academicTitle;
            Position = positin;
        }


        public override string ToString()
        {
            return $"Lecturer |  Academic Title: {AcademicTitle}, Position: {Position}";
        }
    }
}
