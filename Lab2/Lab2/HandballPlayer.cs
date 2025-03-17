using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class HandballPlayer:Player
    {
        public HandballPlayer(string fn, string ln, DateTime dob, string p,
            string c, int sg=0) : base(fn, ln, dob, p, c, sg)
        { }
        public override void ScoreGoal()
        {
            base.ScoreGoal();
        }
     













    }
}
