using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium5
{
    public class Cage
    {
        private int _capacity;
        private bool _needCleaning;
        private IList<Animal> _animals;
        private int _id;

        public int Capacity { get { return _capacity; } set { _capacity = value; } }
        public bool NeedCleaning { get { return _needCleaning; } set { _needCleaning = value; } }

        public Cage(int capacity, bool cleaning, IList<Animal> animals)
        {
            _capacity = capacity;
            _needCleaning = cleaning;
            _animals = animals;
        }

        public IList<Animal> Animals { get { return _animals; } }
        public int Id { get { return _id; } set { _id = value; } }

        public void cleanCage()
        {
            _needCleaning = false;
        }

        public void expandCage(int expandCapacity)
        {
            if ( expandCapacity > 0)
            {
                _capacity += expandCapacity;
            }
                
        }

        public override string ToString()
        {
            return $"id: {_id}, capacity: {_capacity}, animals: {_animals.Count()}, needs cleaning: {_needCleaning}"; 
        }
    }
}
