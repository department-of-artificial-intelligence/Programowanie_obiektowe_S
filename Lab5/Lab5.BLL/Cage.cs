using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        protected int _capacity;
        protected bool _needsCleaning;
        protected IList<Animal> _animals;

        public Animal Animal
        {
            get => default;
            set
            {
            }
        }
    }
}