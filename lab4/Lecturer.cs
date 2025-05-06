using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.bll {
	public class Lecturer : Person {
		public string AcademicTitle { get; set; }
		public string Position { get; set; }

		public Lecturer(string firstName, string lastName, DateTime dateOfBirth,
							string academicTitle, string position)
						: base(firstName, lastName, dateOfBirth) {
			AcademicTitle = academicTitle;
			Position = position;
		}

		public override string ToString() {
			string napis = base.ToString() + " ";

			napis += $"AcademicTitle: {AcademicTitle} ";
			napis += $"Position: {Position}";

			return napis;
		}
	}
}
