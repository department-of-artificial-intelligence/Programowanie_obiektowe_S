using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	public class Person
	{
		private string[] _registrationNumbers;

		public int MaxCarCount { get; set; } = 3; // Maximum cars allowed
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public int CarsCount { get; private set; }

		public Person()
		{
			FirstName = "Unknown";
			LastName = "Unknown";
			Address = "Unknown";
			_registrationNumbers = new string[MaxCarCount];
			CarsCount = 0;
		}

		public Person(string firstName, string lastName, string address)
		{
			FirstName = firstName;
			LastName = lastName;
			Address = address;
			_registrationNumbers = new string[MaxCarCount];
			CarsCount = 0;
		}

		public Person(string firstName, string lastName, string address, string[] cars)
		{
			FirstName = firstName;
			LastName = lastName;
			Address = address;
			_registrationNumbers = new string[MaxCarCount];

			foreach (var car in cars)
			{
				AddCarRegistrationNumber(car);
			}
		}

		public void AddCarRegistrationNumber(string registrationNumber)
		{
			if (CarsCount < MaxCarCount)
			{
				_registrationNumbers[CarsCount] = registrationNumber;
				CarsCount++;
				Console.WriteLine($"Car with registration number {registrationNumber} added.");
			}
			else
			{
				Console.WriteLine("Person cannot own more than the maximum allowed cars.");
			}
		}

		public void RemoveCarRegistrationNumber(string registrationNumber)
		{
			for (int i = 0; i < _registrationNumbers.Length; i++)
			{
				if (_registrationNumbers[i] == registrationNumber)
				{
					_registrationNumbers[i] = null;
					CarsCount--;
					Console.WriteLine($"Car with registration number {registrationNumber} removed.");
					return;
				}
			}
			Console.WriteLine($"Car with registration number {registrationNumber} not found.");
		}

		public override string ToString()
		{
			string regis = "";
			for (int i = 0; i < CarsCount; i++)
			{
				if (_registrationNumbers[i] != null)
				{
					regis += _registrationNumbers[i].ToString() + " ";
				}
			}
			;
			return $"Imie : {FirstName} {LastName} Adres {Address} Liczba Samochodow {CarsCount} Registracje: {regis}";
		}

		public void Details()
		{
			Console.WriteLine(ToString());
		}
	}
}
