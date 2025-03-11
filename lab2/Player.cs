using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Player : Person
    {
        private string _positian;
        private string _club;
        private int _scoredGoals;

        public Player()
        {
            _positian = "brak";
            _club = "brak";
            _scoredGoals = 0;
        }

        public Player(string firstName, string lastName, DateTime dateOfBirth, 
                      string position, string club, int scoredGoals) : 
                      base(firstName, lastName, dateOfBirth)
        {
            _positian = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }

       

        public string Position
        {
            get { return _positian; }
            set { _positian = value; }
        }

        public string Club
        {
            get { return _club; }
            set { _club = value; }
        }

        public int ScoredGoals
        {
            get { return _scoredGoals; }
            set { _scoredGoals = value; }
        }

        public override string ToString()
        {
            return  base.ToString() +
                    $"Players | Positon: {_positian}, Club: {_club}, Scoredgoals: {_scoredGoals}";
        }

        public void ScoreGoal()
        {
            _scoredGoals++;
        }
    }
}
