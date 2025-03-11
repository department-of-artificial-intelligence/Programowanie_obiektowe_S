using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class FootballPlayer : Player
    {
        public FootballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals): base(firstName, lastName, dateOfBirth, position, club, scoredGoals) { }
        public override void ScoreGoal()
        {
            base.ScoreGoal();
            Console.WriteLine("Football Player scored a goal!");
        }
    }
}
