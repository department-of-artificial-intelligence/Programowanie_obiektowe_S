using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo:IContainer
    {
        protected string _name;
        public List<Employee> Employees { get; set; }
        public List<Cage> Cages { get; set; }

        public List<Animal> Animals { get; set; }

        public string Name { get=>_name; set=>_name=value; }

        public Zoo(string name, List<Employee> employees, List<Cage> cages, List<Animal> animals)
        {
            Name= name;
            Employees = employees;
            Cages = cages;
            Animals = animals;
        }

        public Cage BuildCage(int capacity, bool isDirty)
        {
            return new Cage(capacity, isDirty,new List<Animal>());
        }

        public void ExpandCage(Cage cage, int v)
        {
            cage.Capacity += v;
        }

        public CageSupervisor HireEmployee(string v1, string v2, DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}