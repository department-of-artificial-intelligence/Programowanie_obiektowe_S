using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab2
{
    public class Player: Person
    {
        private string _position;
        private string _club;
        private int _scoredGoals;

        public string Position { get { return _position; } set {  _position = value; } }

        public string Club { get { return _club; } set { _club = value; } }
        public int ScoredGoals { get {  return _scoredGoals; } set { _scoredGoals = value; } }

        public Player(string firstName = "none", string lastName = "none", DateTime dateOfBirth = default(DateTime), 
                        string position = "none ", string club = "none" , int scoredGoals = -1) 
        :base(firstName, lastName, dateOfBirth)
        {
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, position = {_position}, club = {_club}, scored goals = {_scoredGoals} ";
        }

        public void ScoreGoal()
        {
            _scoredGoals += 1;
        }

    }
}
