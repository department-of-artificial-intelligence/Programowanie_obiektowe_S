using Crud.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab4.bll {
	public class Student : Person, Crud.Extensions.IContainer {
		private static int id = 0;

		public IList<FinalGrade> Grades { get; set; }
		public int Semester { get; set; }
		public int Group { get; set; }
		public int IndexId { get; set; }
		public string Specialization { get; set; }
		public double AverageGrades {
			get {
				double average = 0;

				if (this.Grades.Count > 0) {
					average = this.Grades.ToList().Sum(grade => grade.Value);
					average = average / this.Grades.Count;
				}

				return average;
			}
		}

		public Student(string firstName, string lastName, DateTime dateOfBirth,
							string specialization, int group, int semester = 1)
					  : base(firstName, lastName, dateOfBirth) {
			this.IndexId = Student.id;
			Student.id += 1;
			this.Grades = new List<FinalGrade>();
			Specialization = specialization;
			Group = group;
			Semester = semester;
		}

		public override string ToString() {
			string napis = base.ToString() + " ";

			napis += $"Semester: {Semester} ";
			napis += $"Group: {Group} ";
			napis += $"IndexId: {IndexId}";
			napis += $"Specialization: {Specialization}";
			napis += $"AverageGrades: {AverageGrades} ";

			napis += "Grades:\n";
			this.Grades.ToList().ForEach(grade => napis += (grade + "\n"));

			return napis;
		}

	}
}
