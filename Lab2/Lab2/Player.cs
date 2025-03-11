using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2
{
    public class Player:Person
    {
        protected string _position;
        protected string _club;
        protected int _scoredGoals;
        public string Position { get { return _position; } }    
        public string Club { get { return _club;} }
        public int ScoredGoals { get {  return _scoredGoals; } }
        public Player()
        {
            _position = "undefined";
            _club = "undefined";
            _scoredGoals = 0;
        }
        public Player(string FirstName, string LastName, DateTime DateOfBirth, string Position, string Club, int ScoredGoals)
            : base (FirstName,LastName,DateOfBirth)
        {
            _position = Position;
            _club = Club;
            _scoredGoals = ScoredGoals;
        }
        public override string ToString()
        {
            return $"First name: {FirstName}, Last Name: {LastName}, Date of Birth {DateOfBirth}, Position: {Position}, Club: {Club}, Scored Goals: {ScoredGoals}";
        }
        public void ScoreGoal()
        {
            _scoredGoals++;
        }
    }
}
