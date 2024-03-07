using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_po
{
    public class Player: Person
    {
        private string _position;
        private string _club;
        private int _scoredGoals;

        public string Position { get { return _position; } set { _position = value; } }
        public string Club { get { return _club; } set { _club = value; } }
        public int ScoredGoals { get {  return _scoredGoals; } set { _scoredGoals  = value; } }

        public Player() 
        {
            _position = "";
            _club = "";
            _scoredGoals = 0;
        }

        public Player(string firstName, string lastName, DateTime dateOfBirth, string positin, string club, int scoredGoals)
        : base(firstName, lastName, dateOfBirth)
        {
            _position = firstName;
            _club = lastName;
            _scoredGoals = scoredGoals;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $" position: {_position}, club: {_club}, scored goals: {_scoredGoals}";
            return str;
        }

        public void ScoreGoal()
        {
            ScoredGoals++;
        }
    }
}
