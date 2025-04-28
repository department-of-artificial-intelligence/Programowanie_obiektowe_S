using Crud.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.bll {
	public class Subject : IDisplayable {
		public string Name { get; set; }
		public string Specialization { get; set; }
		public int Semester { get; set; }
		public int HourCount { get; set; }

		public Subject(string name, string specialization, int semester, int hourCount) {
			Name = name;
			Specialization = specialization;
			Semester = semester;
			HourCount = hourCount;
		}

		public override string? ToString() {
			string napis = "";

			napis += $"Name: {Name} ";
			napis += $"Specialization: {Specialization} ";
			napis += $"Semester: {Semester} ";
			napis += $"HourCount: {HourCount}";

			return napis;
		}
	}
}
