using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
	internal class Student : Person {
		private int _year;
		private int _group;
		private int _indexId;
		private List<Grade> _grades;

		public Student() {
		}

		public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
				: base(firstName, lastName, dateOfBirth) {
			_year = year;
			_group = group;
			_indexId = indexId;
			this._grades = new List<Grade>();
		}

		public int Year {
			get { return _year; }
			set { _year = value; }
		}

		public int Group {
			get { return _group; }
			set { _group = value; }
		}

		public int IndexId {
			get { return _indexId; }
			set { _indexId = value; }
		}

		public List<Grade> Grades {
			get => this._grades;
		}

		public void AddGrade(string subjectName, double value, DateTime date) {
			this.Grades.Add(new Grade(subjectName, value, date));
		}

		public void AddGrade(Grade grade) {
			this.Grades.Add(new Grade(grade.SubjectName, grade.Value, grade.Date));
		}

		public override string ToString() {
			string napis = base.ToString() + " " +
				   $"rok: {this.Year}, " +
				   $"grupa: {this.Group}, " +
				   $"index id: {this.IndexId} " +
				   $"oceny: ";

			this.Grades.ForEach(grade => napis = napis + grade.ToString() + '\n');

			return napis;
		}

	}
}
