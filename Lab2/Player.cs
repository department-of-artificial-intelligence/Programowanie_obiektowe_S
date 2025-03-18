using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
	internal class Player : Person {
		private string _position;
		private string _club;
		private int _scoredGoals;

		public Player() {
		}

		public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
			: base(firstName, lastName, dateOfBirth) {
			_position = position;
			_club = club;
			_scoredGoals = scoredGoals;
		}

		public string Position {
			get => _position;
			set => _position = value;
		}

		public string Club {
			get => _club;
			set => _club = value;
		}

		public int ScoredGoals {
			get => _scoredGoals;
			set => _scoredGoals = value;
		}

		public override string ToString() {
			return base.ToString() +
				   $" pozycja: {this.Position}, " +
				   $"klub: {this.Club}, " +
				   $"zdobyte punkty {this.ScoredGoals}";
		}

		public void ScoreGoal() {
			this.ScoredGoals += 1;
		}

	}
}
