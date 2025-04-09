using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class Animal
    {
        protected string _foodType;
        protected int _legsCount;
        protected string _origin;
        protected string _species;

        public Zoo Zoo
        {
            get => default;
            set
            {
            }
        }

        public Cage Cage
        {
            get => default;
            set
            {
            }
        }
    }
}