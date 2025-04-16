using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Student : Person
    {
        private int id;
		public IList<FinalGrade>? Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string? Specialization { get; set; }
        public double AverageGrades { get; set; }

		public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester) : base(firstName, lastName, dateOfBirth)
		{
            Specialization = specialization;
            Group = group;
            Semester = semester;
		}

		public override string ToString()
		{
			string grades = "";
			if (Grades != null)
				foreach (var grade in Grades)
					grades += grade.ToString();
			return base.ToString() + $"Student`s semester: {Semester}\nGroup: {Group}\n" +
                $"Index id: {IndexId}\nSpecialization: {Specialization}\nAverage grades: {AverageGrades}\n" +
                $"Final grades:\n{grades}\n";
		}
	}
}
