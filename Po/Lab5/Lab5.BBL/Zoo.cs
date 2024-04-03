using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BBL
{
    public class Zoo
    {
        private string _name;
        private System.Collections.Generic.IList<Employee> _employee;

        public string Name
        {
            get;set;
        }

        public System.Collections.Generic.IList<Employee> Employe
        {
            get;set;
        }

        public System.Collections.Generic.IList<Cage> _Cage
        {
            get;
            set;
            
        }

        public System.Collections.Generic.IList<Animal> _Animal
        {
            get;
            set;
        }

        public Cage BuildCage(int id, bool IsAnimal)
        {
            throw new System.NotImplementedException();
        }

        public void ExpandCage(Cage cage, int number)
        {
            throw new System.NotImplementedException();
        }
    }
}