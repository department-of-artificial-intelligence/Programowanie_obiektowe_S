using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class Animal
    {
        private string _foodType;
        private int _legsCount;
        private string _origin;
        private string _species;

        public Zoo Zoo
        {
            get => default;
            set
            {
            }
        }
    }

    public class Reptile : Animal
    {
        private bool _venomous;
    }
}