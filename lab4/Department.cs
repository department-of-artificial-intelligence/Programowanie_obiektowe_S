using Crud.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab4.bll {
	public class Department : IDisplayable, IContainer {
		public string Name { get; set; }
		public Person Dean { get; set; }
		public IList<OrganizationUnit> OrganizationUnits { get; set; }
		public IList<Subject> Subjects { get; set; }
		public IList<Student> Students { get; set; }

		public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students) {
			Name = name;
			Dean = dean;
			Subjects = subjects;
			Students = students;
			this.OrganizationUnits = new List<OrganizationUnit>();	
		}

		public override string ToString() {
			string napis = base.ToString() + " ";

			napis += $"Name: {Name} ";
			napis += $"Dean: {Dean} ";

			napis += "OrganizationUnits:\n";
			this.OrganizationUnits.ToList().ForEach(unit => napis += (unit + "\n"));

			napis += "Subjects:\n";
			this.Subjects.ToList().ForEach(subject => napis += (subject + "\n"));

			napis += "Students:\n";
			this.Students.ToList().ForEach(student => napis += (student + "\n"));

			return napis;
		}
	}
}
