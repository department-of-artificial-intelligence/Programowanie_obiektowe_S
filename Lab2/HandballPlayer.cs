using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class HandballPlayer : Player
    {
        public HandballPlayer(string firstName, string lastName, DateTime birthDate, string position, string team)
            : base(firstName, lastName, birthDate, position, team, 0) { }

        public override void ScoreGoal()
        {
            base.ScoreGoal();
            Console.WriteLine("Handball player scored goal!");
        }
    }
}
