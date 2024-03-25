using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab02
{
    public class FootBallPlayer : Player
    {
        public FootBallPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth, position, club, scoredGoals)
        {

        }
        public override void ScoreGoal()
        {
            Console.WriteLine("Football player scored goal!");
        }
    }
}
