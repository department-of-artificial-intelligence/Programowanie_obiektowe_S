using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class FootballPlayer : Player
    {
        public FootballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int skoreGoals)
            : base(firstName, lastName, dateOfBirth, position, club, skoreGoals)
        {
        }
        public override void ScoreGoal()
        {
            base.ScoreGoal();
            Console.WriteLine("Football player scored goal");
        }

    }
}
