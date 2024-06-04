using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Lab8.BLL
{
    public class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Faculty { get; set; }
        public int StudentNo { get; set; }
        public List<Grade> Grades { get; set; }

        public string GradesString
        {
            get
            {
                string gs = string.Join("", Grades);
                return gs;
            }
        }

        public Student(string firstName, string surName, string faculty, int studentNo)
        {
            FirstName = firstName;
            SurName = surName;
            Faculty = faculty;
            StudentNo = studentNo;
            Grades = new List<Grade>();
        }

        public Student() 
        {
            FirstName = "No name";
            SurName = "No sur name";
            Faculty = "No faculty";
            StudentNo = 0;
            Grades = new List<Grade>();
        }
        public override string ToString()
        {
            var str = $"First name: {FirstName}, sur name: {SurName}" +
                $", faculty: {Faculty}, student number: {StudentNo} ";
            str += string.Join<Grade>('\n', Grades);
            return str;
        }
    }
}
