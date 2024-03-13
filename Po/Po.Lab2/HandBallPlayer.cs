using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab2
{
    public class HandBallPlayer : Player
    {
        public HandBallPlayer(string firstName, string lastName,
            DateTime birthDate, string position, string club, int scoreGoals=0) : base(firstName, lastName, birthDate, position, club, scoreGoals) { }
        public override void ScoreGoals()
        {
             base.ScoreGoals();
            Console.WriteLine("Handball player scored goal!");
        }

    }
}
