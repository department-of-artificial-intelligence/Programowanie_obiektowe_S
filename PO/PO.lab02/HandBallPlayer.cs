using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab02
{
    public class HandBallPlayer : Player
    {
        public HandBallPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals = 1) : base(firstName, lastName, dateOfBirth, position, club, scoredGoals) 
        {
            
        }
        public override void ScoreGoal()
        {
            base.ScoreGoal();
            Console.WriteLine("Handball player scored goal!");
        }
    }
}
