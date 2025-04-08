using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Lab2
{
    class FootballPlayer : Player
    {
		public FootballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth, position, club, scoredGoals) { }

		public override void ScoreGoal()
		{
			Console.WriteLine("Football player scored goal!");
			base.ScoreGoal();
		}
	}
}
