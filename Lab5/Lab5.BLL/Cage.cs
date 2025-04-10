using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Cage : Generic.Extensions.IContainer
    {
        private static int _nextId = 1;

        private int _capacity;
        private bool _keepCleaning;
        private IList<Animal> _animals;
        private int _id;

        public int Id => _id;
        public int Capacity { get { return _capacity; } set { _capacity = value; } }
        public IList<Animal> Animals{get { return _animals; }set { _animals = value; }}
        public bool KeepCleaning{ get { return _keepCleaning; }set { _keepCleaning = value; }}



        public Cage(int capacity, bool keepCleaning, IList<Animal> cages)
        {
            _id = _nextId++;
            _capacity = capacity;
            _keepCleaning = keepCleaning;
            _animals = cages;
        }

        public Cage(int capacity, bool keepCleaning)
        {
            _id = _nextId++;
            _capacity = capacity;
            _keepCleaning = keepCleaning;
            _animals = new List<Animal>();
        }

        public override string ToString()
        {
            string flag;
            if (KeepCleaning == true) flag = "Cages need cleaning";
            else flag = "Cages don't need cleaning";

            string result = $"Capacity : {Capacity}, {flag}\n";
            
            if(Animals.Count == 0)
            {
                return result;
            }
            result += "Animals:\n";
            foreach (var animal in Animals)
            {
                result += animal.ToString() + '\n';
            }
            result = result.Substring(0, result.Length - 1);
            return result;
        }

    }
}