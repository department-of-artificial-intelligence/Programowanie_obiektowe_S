using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab2
{
    public class FootballPlayer : Player
    {
        public FootballPlayer(string firstName, string lastName,
            DateTime birthDate, string position, string club, int scoreGoals) : base(firstName, lastName, birthDate, position, club, scoreGoals) { }
        public override void ScoreGoals()
        {
            base.ScoreGoals();
            Console.WriteLine("Football player scored goal!");
        }
    }
}
