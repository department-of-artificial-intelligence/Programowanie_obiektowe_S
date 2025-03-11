using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Player
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
        public Player()
        {
            _position = "nieznana";
            _club = "nieznany";
            _scoredGoals = 0;
        }
        public Player(string position, string club, int scoredGoals)
        {
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }

    }
}