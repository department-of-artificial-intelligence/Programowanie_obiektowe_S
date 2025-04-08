using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private int _capacity;
        private bool _needCleaning;
        private static int _idc = 0;
        private int _id;
        private System.Collections.Generic.List<Animal> _animals;

        public Cage(int capacity, bool needCleaning, System.Collections.Generic.List<Animal> animals)
        {
            _capacity = capacity;
            _needCleaning = needCleaning;
            _animals = animals;
            _idc++;
            _id = _idc;
        }

        public Animal Animal
        {
            get => default;
            set
            {
            }
        }

        public override string ToString()
        {
            string details = $"Cage: |\nId: {_id} Animals:\n";
            foreach (var i in _animals)
                details += i.ToString();
            return details + $"Capacity: {_capacity}, NeedCleaning: {_needCleaning}";
        }
    }
}