using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4 {
	class Lecturer : Person {

		public string AcademicTitle { get; set; }
		public string Position { get; set; }

		public Lecturer(string firstName, string lastName, DateTime dateOfBirth, string academicTitle, string position) : base(firstName, lastName, dateOfBirth) {
			this.AcademicTitle = academicTitle;
			this.Position = position;
		}

		public override string ToString() {
			return base.ToString() +
				   $", AcademicTitle: {this.AcademicTitle}" +
				   $", Position: {this.Position}";
		}
	}
}
