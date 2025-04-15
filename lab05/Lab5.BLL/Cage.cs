using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private int _capacity;
        private bool _clean;
        private IList<Animal> _animals;

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public bool Clean
        {
            get { return _clean; }
            set { _clean = value; }
        }

        public IList<Animal> Animals
        {
            get { return _animals; }
            set { _animals = value; }
        }


        public Cage() { }

        public Cage(int capacity, bool clean, IList<Animal> animals)
        {
            _capacity = capacity;
            _clean = clean;
            _animals = animals;
        }

    }
}