using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BBL
{
    public class Zoo
    {

        public System.Collections.Generic.IList<Animal> Animals
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.IList<Employee> Employees
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.IList<Cage> Cages
        {
            get => default;
            set
            {
            }
        }

        public string Name
        {
            get => default;
            set
            {
            }
        }

        public Cage BuildCage()
        {
            throw new System.NotImplementedException();
        }

        public void ExpandCage()
        {
            throw new System.NotImplementedException();
        }
    }
}