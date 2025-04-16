using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Person
    {
		public string? FirstName { get; set; }
		public string? LastName { get; set; }

		public Person()
		{
			FirstName = "Person default first name";
			LastName = "Person default last name";
		}

		public Person(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public override string ToString()
		{
			return $"Person first name: {FirstName}\nLast name: {LastName}\n";
		}

		public void Details() 
		{
			Console.WriteLine(ToString());
		}
	}
}
