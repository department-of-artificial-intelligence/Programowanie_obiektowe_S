using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Student: Person
    {
        private int Id;
        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId
        {
            get { return Id; }
            set { Id = value; }
        } 
        public string Specialization { get; set; }
        public double AverageGrades
        {
            get { return AverageGrades; }
        }
        //Student student1 = new Student("Jan", "Kowalski", new DateTime(1995, 1, 1), "Informatyka", 1);
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1)
            : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
        }

        public override string ToString()
        {
            string result = base.ToString() + $", Specialization: {Specialization}, Semester: {Semester}, Group: {Group}\n";

            if(Grades?.Count > 0)
            {
                result += "Grades:\n";
                foreach (var Grade in Grades)
                {
                    result += Grade.ToString() + "\n";
                }
            }

            return result;
        }
    }
}
