using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class Cage : Employee
    {
        protected int _id;
        protected int _capacity;
        protected bool _cleaning;
        protected List<Animal> _animals;

        public Zoo Zoo
        {
            get => default;
            set
            {
            }
        }
    }
}