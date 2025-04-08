using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    class Lecturer:Person
    {
        public string AcademicTitle
        {
            get; set;
        }

        public string Position
        {
            get; set;
        }
        public Lecturer(string firstname, string lastname, DateTime dateOfBirth, string academicTitle, string position):base(firstname, lastname, dateOfBirth)
        {
            AcademicTitle = academicTitle;
            Position = position;
        }

        public override string ToString()
        {
            return $"AcademicTitle: {AcademicTitle}, Position: {Position}, FirstName: {FirstName}, LastName: {LastName} and DateOfBirth: {DateOfBirth}";
        }


    }
}
