using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Animal
    {
        protected string _spieces;
        protected string _origin;
        protected string _diet;
        protected string _region;
        protected string _numOfLegs;

        public Cage Cage
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
    }
}