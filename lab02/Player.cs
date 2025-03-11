using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class Player: Person{
        
        private string _position;
        private string _club;
        public int _scoredGoals;

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
            get { return _scoredGoals;}
            set { _scoredGoals = value;}
        }

        public Player():base()
        {
            _position = string.Empty;
            _club = string.Empty;
            _scoredGoals = 0;
        }

        public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals):base(firstName,lastName,dateOfBirth)
        {
            _position = position;
            _club = club;
            _scoredGoals=scoredGoals;
        }


        public override string ToString()
        {
            return base.ToString() + $" pozycja: {_position}, klub: {_club}, ilosc goli: {_scoredGoals}"; 
                }        


        public void ScoreGoal()
        {
            _scoredGoals++;
        }


    }
}
