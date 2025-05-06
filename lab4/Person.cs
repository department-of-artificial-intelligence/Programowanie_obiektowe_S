using Crud.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.bll {
	public abstract class Person : IDisplayable {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }

		protected Person(string firstName, string lastName, DateTime dateOfBirth) {
			FirstName = firstName;
			LastName = lastName;
			DateOfBirth = dateOfBirth;
		}

		public override string ToString() {
			string napis = "";

			napis += $"FirstName: {FirstName} ";
			napis += $"LastName: {LastName} ";
			napis += $"DateOfBirth: {DateOfBirth}";

			return napis;
		}

	}
}
