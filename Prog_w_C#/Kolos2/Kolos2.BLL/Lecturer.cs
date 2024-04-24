using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos2.BLL
{
    public class Lecturer : Person
    {
        public Lecturer(string firstName, string lastName, DateTime dateOfBirth , string academicTitle , string position) : base(firstName, lastName, dateOfBirth)
        {
            AcademicTitle = academicTitle;
            Position = position;
        }

        public string AcademicTitle { get; set; }
        public string Position { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" Tytul akademicki: {AcademicTitle} Pozycja: {Position}";
        }
    }
}
