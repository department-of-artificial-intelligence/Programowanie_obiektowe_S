using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace Lab5.BLL
{
    public class Zoo : IContainer
    {
        private string _name;
        private IList<Cage> _cages;
        private IList<Employee> _employees;
        private IList<Animal> _animals;

        public string Name { get; set; }

        public IList<Cage> Cages { get => _cages; set => _cages = value; }
        public IList<Employee> Employees { get; set; }

        public IList<Animal> Animals { get => _animals; set => _animals = value; }



        public Zoo(string nam, IList<Employee> employees, IList<Cage> cages, IList<Animal> animals)
        {
            Name = nam;
            Cages = cages;
            Employees = employees;
            Animals = animals;
        }

        public Cage BuildCage(int cap, bool clear)
        {
            Cage cage = new Cage(cap, clear, new List<Animal>());
            Cages.Add(cage);
            return Cages[Cages.Count - 1];
        }

        public void ExpandCage(Cage cage, int cap)
        {
            var find = Cages.FirstOrDefault(c => c.Id == cage.Id);
            find.Pojemnosc += cap;

        }

        public Employee HireEmployee(string FName, string LName, DateTime DOB)
        {
            var employee = new CageSupervisor(FName, LName, DOB, DateTime.Now, new List<Cage>());
            Employees.Add(employee);
            return employee;

        }

        public override string ToString()
        {
            string str = $"Name {Name}, in zoo:";
            foreach (var cage in Cages)
            {
                str += "\n" + cage + "\n";
            }
            return str;
        }
    }





}