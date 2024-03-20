using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab02
{
    public class Player : Person
    {
        private string _position = null!;
        private string _club = null!;
        private int _scoredGoals;

        public Player() : base()
        {
            _position = "Brak pozycji";
            _club = "Brak klubu";
            _scoredGoals = 0;
        }

        public Player(string firstName, string lastName, DateTime dateOfBirth,
            string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth)
        {
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }

        public string Position { get => _position; set => _position = value; }
        public string Club { get => _club; set => _club = value; }
        public int ScoredGoals { get => _scoredGoals; set => _scoredGoals = value; }

        public override string ToString()
        {
            return $"Imie: {_firstName}, nazwisko: {_lastName}, data urodzin: " +
                $"{_dateOfBirth}, pozycja: {_position}, klub: {_club}, " +
                $"zdobyte gole: {_scoredGoals}";
        }

        public void ScoreGoal()
        {
            _scoredGoals++;
        }
    }
}
