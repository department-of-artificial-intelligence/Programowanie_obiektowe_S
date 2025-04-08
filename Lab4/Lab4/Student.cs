using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Student : Person, IContainer, IDisplayable
    {
        private static int id;

        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId
        {
            get { return id; }
            set { id = value; }
        }
        public string Specialization { get; set; }
        public double AverageGrades { get; }
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1)
        : base(firstName, lastName, dateOfBirth)
        {
            this.Specialization = specialization;
            this.Group = group;
            this.Semester = semester;
            this.Grades = new List<FinalGrade>();
        }
        public override string ToString()
        {
            string text = base.ToString();

            text += $", id: {this.IndexId}";
            text += $", Semester: {this.Semester}";
            text += $", Group: {this.Group}";
            text += $", Specialization: {this.Specialization}";
            text += $", AverageGrades: {this.AverageGrades:F2}";    //:F2 formatowanie do 2 miejsc po przecinku

            text += $", Grades:\n";
            this.Grades.ToList().ForEach(grade => text += grade + "\n");

            return text;
        }

    }
}