using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Animal
    {
        private int _foodType;
        private int _legsCount;
        private int _origin;
        private int _species;

        public string Origin
        {
            get => default;
            set
            {
            }
        }

        public int LegsCount
        {
            get => default;
            set
            {
            }
        }

        public string FoodType
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

        public Cage Klatka
        {
            get => default;
            set
            {
            }
        }

        public Zoo Zoo
        {
            get => default;
            set
            {
            }
        }
        public Animal()
        {
            Origin = "";
            LegsCount = 0;
            FoodType = "";
            Species = "";
            Klatka = new Cage();
        }
    }
}