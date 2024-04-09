using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Bll
{
    public class Player : Person
    {
        private string _position;
        private string _club;
        private int _scoredGoals;

        public string Position { get { return _position; } set {  _position = value; } }
        public string Club { get { return _club; } set { _club = value; } }
        public int ScoredGoals { get { return _scoredGoals; } set { _scoredGoals = value; } }
        public Player() : base() {
            _position = string.Empty;
            _club = string.Empty;
            _scoredGoals = 0;
        }
        public Player(string firstname,string lastname,DateTime dateofbirth,string position,string club,int goals) : base(firstname,lastname,dateofbirth) {
            _position = position;
            _club = club;
            _scoredGoals = goals;
        }
        public override string ToString()
        {
            string tmp = base.ToString() + $" Pozycja: {_position}, Klub: {_club}, Strzelone bramki: {_scoredGoals}";
            return tmp;
        }
        public virtual void ScoreGoal() { _scoredGoals++; }
    }
}
