using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab4
{
    internal class Lecturer : Person
    {
        public string AcademicTitle { get; set; }
        public string Position { get; set; }
        public Lecturer(string firstName, string lastName, 
            DateTime dateOfBirth, string academicTitle, string position) : base(firstName, lastName, dateOfBirth)
        {
            AcademicTitle = academicTitle;
            Position = position;
        }
        public override string ToString()
        {
            return base.ToString + $"Academic Title: {AcademicTitle}, " +
                $"Position: {Position}";
        }
    }
}
