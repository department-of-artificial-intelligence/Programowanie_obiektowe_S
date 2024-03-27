using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private int _number;

        public int Number
        {
            get 
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }

        public bool NeedClean
        {
            get; set;
        }

        public float Capacity
        {
            get; set;
        }

        public System.Collections.Generic.List<Animal> animalsList
        {
            get; set;
        }
    }
}