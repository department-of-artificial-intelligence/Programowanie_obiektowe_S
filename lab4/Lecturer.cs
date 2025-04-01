using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Lecturer:Person
    {
        private string _academicTitle;
        private string _position;

        public string AcademicTitle
        {
            get => _academicTitle;
            set => _academicTitle = value;
        }

        public string Position
        {
            get => _position;
            set => _position = value;
        }

        public Lecturer(string firstName, string lastName,
            DateTime dateOfBirth, string academicTitle, string position) : base(firstName, lastName, dateOfBirth)
        {
            AcademicTitle = academicTitle;
            Position = position;
        }
    }
}
