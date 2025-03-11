using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Player : Person
    {
        private string _position;
        private string _club;
        private int _scoredGoals;

        public Player()
        {
            _position = "brak pozycji";
            _club = "brak klubu";
            _scoredGoals = 0;


        }
        //public Player(string firsName) { }




    }
}
