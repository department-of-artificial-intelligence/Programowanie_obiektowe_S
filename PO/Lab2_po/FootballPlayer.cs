using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_po
{
    public class FootballPlayer: Player
    {
        public FootballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
        :base (firstName, lastName, dateOfBirth, position, club, scoredGoals) { }
        public void ScoreGoal()
        {
            base.ScoreGoal();
            Console.WriteLine("Football player scored goal");
        }
    }
}
