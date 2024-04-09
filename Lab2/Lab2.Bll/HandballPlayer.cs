using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Bll
{
    public class HandballPlayer : Player
    {
        public HandballPlayer(string firstname, string lastname,DateTime date,string position,string club,int scoreGoals=0):base(firstname,lastname,date,position,club,scoreGoals) { }
        public override void ScoreGoal()
        {
            base.ScoreGoal();
            Console.WriteLine("Handball player scored goal!");
        }

    }
}
