using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Player : Person
    {
        private string _position = null!;
        private string _club = null!;
        private int _scoredGoals;

        public string Position { get => _position; set => _position = value; }
        public string Club { get => _club; set => _club = value; }
        public int ScoredGoals { get => _scoredGoals; set => _scoredGoals = value; }

        public Player()
        {
            _position = "nieznana";
            _club = "nieznany";
            _scoredGoals = 0;
        }
        public Player(string fristName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
        : base(fristName, lastName, dateOfBirth)
        {
            _position = "nieznana";
            _club = "nieznany";
            _scoredGoals = 0;
        }

        public override string ToString()
        {
            return $"Firstname: {_firstName}, Lastname: {_lastName},Dateofbirth: {_dateOfBirth}, Position: {_position}, Club: {_club}, ScoredGoals: {_scoredGoals} ";
        }
        void ScoredGoal()
        {
            _scoredGoals++;
        }
    }

}

