using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gosha
{
    public class Zoo
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Cage> Cages { get; set; }
        public List<Animal> Animals { get; set; }

        public Zoo(string name, List<Employee> employees, List<Cage> cages, List<Animal> animals)
        {
            Name = name;
            Employees = employees;
            Cages = cages;
            Animals = animals;
        }

        public Cage BuildCage(int capacity, bool needsCleaning)
        {
            Cage newCage = new Cage(capacity, needsCleaning, new List<Animal>());
            Cages.Add(newCage);
            return newCage;
        }

        public void ExpandCage(Cage cage, int additionalCapacity)
        {
            cage.Capacity += additionalCapacity;
            Console.WriteLine($"Cage expanded to capacity {cage.Capacity}");
        }
    }
}