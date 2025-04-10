using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public static class ZooExtensions
    {
        // Extension method for Zoo to hire an Employee
        public static Employee HireEmployee(this Zoo obj, string name, string lastName, DateTime dateOfHire)
        {
            Employee employee = new Employee(name, lastName, dateOfHire);

            // Get the list of employees using reflection
            var propertyInfo = obj.GetType().GetProperties()
                .FirstOrDefault(p => p.PropertyType == typeof(IList<Employee>));

            if (propertyInfo != null)
            {
                var list = propertyInfo.GetValue(obj) as IList<Employee>;

                if (list != null)
                {
                    list.Add(employee);
                }
            }
            return employee;
        }
    }
    public class Zoo : Generic.Extensions.IContainer
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