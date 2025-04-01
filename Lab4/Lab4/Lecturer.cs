using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Lecturer:Person
    {
        public string AcademicTitle {  get; set; }
        public string Position { get; set; }
        public Lecturer(string firstName,string lastName,DateTime dateofBirth,string academicTitle,string position):base(firstName,lastName,dateofBirth)
        {
            AcademicTitle = academicTitle;
            Position = position;
        }
        public override string ToString()
        {
            return $"Lecturer: "+base.ToString()+$" Tytul: {AcademicTitle} Pozycja: {Position} ";
        }



    }
}
