using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Lecturer: Person
    {
        public string AcademicTitle { get; set; }
        public string Position { get; set; }
        public Lecturer(string firstName = "none", string lastName = "none", DateTime dateOfBirth = default(DateTime),
            string academicTitle = "none", string position = "none") : base(firstName, lastName, dateOfBirth)
        {
            AcademicTitle = academicTitle;
            Position = position;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, title = {AcademicTitle}, position = {Position}";
        }

    }
}
