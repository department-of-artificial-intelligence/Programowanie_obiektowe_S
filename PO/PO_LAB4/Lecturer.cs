using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_LAB4
{
    public class Lecturer : Person
    {
        public string AcademicTite {  get; set; }
        public string Position {  get; set; }
        public Lecturer(string FName, string LName, DateTime DOB, string academicttl, string pos) : base(FName, LName, DOB)
        {
            AcademicTite = academicttl;
            Position = pos;
        }
        public override string ToString()
        {
            return $"Lecturer: {AcademicTite} | {Position} | {base.ToString()}";
        }
    }
}
