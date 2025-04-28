using Crud.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.bll {
	public class OrganizationUnit : IDisplayable, IContainer {
		public string Name { get; set; }
		public string Adress { get; set; }
		public IList<Lecturer> Lecturers { get; set; }

		public OrganizationUnit(string name, string adress, IList<Lecturer> lecturers) {
			Name = name;
			Adress = adress;
			Lecturers = lecturers;
		}

		public override string ToString() {
			string napis = "";

			napis += $"Name: {Name} ";
			napis += $"Adress: {Adress} ";

			napis += "Lecturers:\n";
			Lecturers.ToList().ForEach(lecturer => napis += (lecturer + "\n"));

			return napis;
		}
	}
}
