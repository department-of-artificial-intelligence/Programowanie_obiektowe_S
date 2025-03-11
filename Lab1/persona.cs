using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using lab31;
using lab3;
namespace labmain
{
	public class Person
	{
		protected string _firstName = "";
		protected string _lastName = "";
		protected DateTime _birthDate;

		public string firstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}
		public string lastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}
		public DateTime birthDate
		{
			get { return _birthDate; }
			set { _birthDate = value; }
		}
		public Person() { }
		public Person(string firstName, string lastName, DateTime birthDate)
		{
			_firstName=firstName;
			_lastName=lastName;
			_birthDate=birthDate;
			_firstName=firstName;
			_lastName=lastName;
			_birthDate=birthDate;
		}
		public override string ToString()
		{
			return $"brooo";
		}

		public void Details()
		{
			Console.WriteLine(this);
		}
	}
	
}