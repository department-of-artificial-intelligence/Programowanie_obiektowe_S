using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private int _capacity;
        private bool _needsCleaning;
        private IList<Animal> _animals;
        private int _id;

        public Animal Animal
        {
            get => default;
            set
            {
            }
        }

        public void ExpandCage()
        {
            throw new System.NotImplementedException();
        }

        public Cage BuildCage()
        {
            throw new System.NotImplementedException();
        }
    }
}