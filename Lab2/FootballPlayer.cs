using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class FootballPlayer : Player
    {
        public FootballPlayer(string firstName, string lastName, DateTime birthDate, string position, string team, int scoredGoals)
            : base(firstName, lastName, birthDate, position, team, scoredGoals) { }

        public override void ScoreGoal()
        {
            base.ScoreGoal();
            Console.WriteLine("Football player scored goal!");
        }
    }
}
