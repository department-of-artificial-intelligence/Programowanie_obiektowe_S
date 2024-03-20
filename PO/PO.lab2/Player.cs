using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab2
{
    public class Player : Person
    {
        private string _position;
        private string _club;
        private int _scoredGoals;
        public string Position
        {
            get { return _position; }
            set { _position = value; }
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
        public Player() : base()
        {
            _position = "-";
            _club = "-";
            _scoredGoals = 0;
        }
        public Player(string imie, string nazwisko, DateTime dataur, string position, string club, int scoredGoals) : base(imie, nazwisko, dataur)
        {
            _position=position;
            _club=club;
            _scoredGoals=scoredGoals;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Position: {_position}, Club: {_club}, ScoreGoals: {_scoredGoals}";
        }
        public void ScoreGoal()
        {
            _scoredGoals++;
        }
    };
}
