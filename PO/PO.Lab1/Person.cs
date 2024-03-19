using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab1
{
	public class Person
	{
		private string _firstName;
		private string _lastName;
		private int _age;
		private string[] _carRegistrationNumbers;
		private int _carCount;

		public string FirstName { get => _firstName; set => _firstName = value; }
		public string LastName { get => _lastName; set => _lastName = value; }
		public int Age { get => _age; set => _age = value; }

		public Person(string firstName, string lastName, int age)
		{
			_firstName = firstName;
			_lastName = lastName;
			_age = age;
			_carRegistrationNumbers = new string[3];
			_carCount = 0;
		}

		public void AddCarRegistrationNumber(string registrationNumber)
		{
			if (_carCount < 3)
			{
				_carRegistrationNumbers[_carCount] = registrationNumber;
				_carCount++;
			}
			else
			{
				Console.WriteLine("Maximum number of cars for this person.");
			}
		}

		public void RemoveCarRegistrationNumber(string registrationNumber)
		{
			for (int i = 0; i < _carCount; i++)
			{
				if (_carRegistrationNumbers[i] == registrationNumber)
				{
					_carRegistrationNumbers[i] = null;
					_carCount--;
					return;
				}
			}
			Console.WriteLine($"Car with registration number {registrationNumber} not found.");
		}

		public override string ToString()
		{
			string carRegistrationNumbers = string.Join(", ", _carRegistrationNumbers);
			return $"Person: {_firstName} {_lastName}, Age: {_age}, Cars: {carRegistrationNumbers}";
		}

		public void Details()
		{
			Console.WriteLine(this.ToString());
		}
	}
}
