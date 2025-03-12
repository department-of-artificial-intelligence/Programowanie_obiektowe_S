using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
	internal class zad1 {

		public class Person {
			protected string _firstname;
			protected string _lastname;
			protected DateTime _dateOfBirth;
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public DateTime DateOfBirth { get; set; }
			public Person() { }
			public Person(string firstName, string lastName, DateTime dateOfBirth) {
				FirstName = firstName;
				LastName = lastName;
				DateOfBirth = dateOfBirth;

			}
			public override string ToString() {
				return $"Imie: {_firstname}, nazwisko {_lastname}, data: {DateOfBirth}";
			}

			virtual public void Detalis() {
				Console.WriteLine(FirstName,LastName,DateOfBirth);
			}
		}

		public class Student : Person {
			private int _year;
			private int _group;
			private int _indexId;
			public int Year { get; set; }
			public int Group { get; set; }
			public int IndexId { get; set; }
			public Student() {}
			public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) {
				FirstName = firstName;
				LastName = lastName;
				DateOfBirth = dateOfBirth;
				Year = year;
				Group = group;
				IndexId = indexId;
			}
			public override string ToString() {
				return base.ToString();
			}
		}

		public class Player: Person {
			private string _position;
			private string _club;
			private int _scoredGoal;
			public string Position { get; set; }
			public string Club { get; set; }
			public int ScoredGoals { get; set; }
			public Player() { }
			public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) {
				FirstName = firstName;
				LastName = lastName;
				DateOfBirth = dateOfBirth;
				Position = position;
				Club = club;
				ScoredGoals = scoredGoals;
			}
			public override string ToString() {
				return base.ToString();
			}
		}

	}
}
