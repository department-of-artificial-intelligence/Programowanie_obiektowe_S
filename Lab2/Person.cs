using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
	internal class Person {
		protected string _firstName;
		protected string _lastName;
		protected DateTime _dateOfBirth;

		public Person() { }

		public Person(string firstName, string lastName, DateTime dateOfBirth) {
			_firstName = firstName;
			_lastName = lastName;
			_dateOfBirth = dateOfBirth;
		}

		public string FirstName {
			get => _firstName;
			set => _firstName = value;
		}

		public string LastName {
			get => _lastName;
			set => _lastName = value;
		}

		public DateTime DateOfBirth {
			get => _dateOfBirth;
			set => _dateOfBirth = value;
		}

		public override string ToString() {
			return $"imie: {this.FirstName}, " +
				   $"nazwisko: {this.LastName}, " +
				   $"data urodzin: {this.DateOfBirth.ToString("dd-MM-yyyy")}";
		}

		public virtual void Details() {
			Console.WriteLine(this);
		}

	}
}
