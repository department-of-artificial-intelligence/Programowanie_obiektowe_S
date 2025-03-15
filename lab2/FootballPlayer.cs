using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class FootballPlayer:Player
    {
        public FootballPlayer(string? firstName, string? lastName, DateTime dateTime, string? position, string? club, int scoreGoals)
            : base(firstName, lastName, dateTime, position, club, scoreGoals) { }
        public override void ScoreGoal()
        {
            base.ScoreGoal();
            Console.WriteLine("Football player scored goal!");
        }

    }
}
