using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        protected float _wingSpan;
        protected int _endurance;

        public int Endurance
        {
            get => default;
            set
            {
            }
        }

        public float WingSpan
        {
            get => default;
            set
            {
            }
        }

        public void Fly()
        {
            throw new System.NotImplementedException();
        }
    }
}