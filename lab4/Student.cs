using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4 {
	class Student : Person {
		private static int id = 0;

		public IList<FinalGrade> Grades { get; set; }

		public int Semester { get; set; }
		public int Group { get; set; }

		public int IndexId {get; set;}

		public string Specialization { get; set; }

		public double AverageGrades { 
			get {
				if (this.Grades is not null || this.Grades.Count != 0) {
					return this.Grades.ToList().Sum(grade => grade.Value) / this.Grades.ToList().Count();
				}
				return 0;         
			} 
		}

		public Student(string firstName, string lastName, DateTime dateOfBirth,
					   string specialization, int group, int semester = 1) : base(firstName, lastName, dateOfBirth) {
			this.Specialization = specialization;
			this.Group = group;
			this.Semester = semester;
			this.Grades = new List<FinalGrade>();

			this.IndexId = Student.id + 1;
        }

		public override string ToString() {
			string napis = base.ToString();

			napis += $", id: {this.IndexId}";
			napis += $", Semester: {this.Semester}";
			napis += $", Group: {this.Group}";
			napis += $", Specialization: {this.Specialization}";
			napis += $", AverageGrades: {this.AverageGrades}";

			napis += $", Grades:\n";
			this.Grades.ToList().ForEach(grade => napis += grade + "\n");

			return napis;
		}

	}
}
