using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo
    {
        private string _name;
        private IList<Employee> _employees;
        private IList<Animal> _animals;
        private IList<Cage> _cages;



        public Zoo(string name, List<Employee> employee, List<Cage> cage, List<Animal> animal)
        {
            _name = name;
            _employees = employee;
            _cages = cage;
            _animals = animal;
        }

        public Cage BuildCage(int capacity, bool keepCleaning)
        {
            Cage tmp = new Cage(capacity, keepCleaning);
            _cages.Add(tmp);
            return tmp;
        }

        public void ExpandCage(Cage Cage, int capacity)
        {
            for(int i =0; i < _cages.Count; i++)
            {
                if(Cage.Id == _cages[i].Id)
                {
                    _cages[i].Capacity = capacity;
                }
            }
        }


        
    }
}