using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public abstract class Animal
    {
        protected string _species;
        protected string _foodType;
        protected int _orgin;
        protected int _legsNum;

        public string FoodType
        {
            get => default;
            set
            {
            }
        }

        public int LegsNum
        {
            get => default;
            set
            {
            }
        }

        public string Orgin
        {
            get => default;
            set
            {
            }
        }

        public string Species
        {
            get => default;
            set
            {
            }
        }
    }
}