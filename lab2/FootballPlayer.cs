using lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class FootballPlayer : Player
    {
        public FootballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName,lastName, dateOfBirth, position,club,scoredGoals)
        { 

        }

        public override void ScoreGoal()
        {
            ScoredGoals++;
            Console.WriteLine($"FootballPlayer {FirstName} {LastName} scored a goal!");
        }


    }
}
