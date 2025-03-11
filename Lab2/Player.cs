using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Player : Person
    {
        private string _position;
        private string _club;
        private int _scoredGoals;

        public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string team, int scoredGoals)
            : base(firstName, lastName, dateOfBirth)
        {
            _position = position;
            _club = team;
            _scoredGoals = scoredGoals;
        }

        public virtual void ScoreGoal()
        {
            _scoredGoals++;
        }

        public override void Details()
        {
            base.Details();
            Console.WriteLine($"Position: {_position}, Team: {_club}, Goals: {_scoredGoals}");
        }
    }
}
