using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class HandballPlayer : Player
    {
        public HandballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth, position, club, scoredGoals) { }

        public override void ScoreGoal()
        {
            base.ScoreGoal();
            Console.WriteLine("Handball player scored goal!");
        }
    }
}
