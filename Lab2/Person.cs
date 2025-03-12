using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	public class Person
	{
		protected string _firstName;
		protected string _lastName;
		protected DateTime _dateOfBirth;

		
		
		public string FirstName
		{
			get {return _firstName; }
			set {_firstName = value; }
		}

		public string LastName
		{
			get { return _lastName ; }
			set { _lastName = value; }
		}
		public DateTime DateOfBirth
		{
			get { return _dateOfBirth; }
			set { _dateOfBirth = value; }
		}

		public Person()
		{
			_firstName = "pusty";
			_lastName = "pusty";
			_dateOfBirth = default(DateTime);
		}

		public Person(string firstName, string lastName, DateTime dateOfBirth)
		{
			_firstName=firstName;
			_lastName=lastName;
			_dateOfBirth=dateOfBirth;
		}

		public override string ToString()
		{
			return $"Person | FirstName: {_firstName}, LastName: {_lastName}, DateTime: {_dateOfBirth}" ;
		}

		virtual public void Details() //Powinna być wirtualna
		{
			Console.WriteLine(this);
		}
	}

}

