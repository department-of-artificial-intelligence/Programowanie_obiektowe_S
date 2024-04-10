using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        protected int _cage_Number;
        protected int _capacity;
        protected bool _requiresCleaning;
        protected System.Collections.Generic.List<Animal> _animals;

        public Employee Employee
        {
            get => default;
            set
            {
            }
        }

        public Zoo Zoo
        {
            get => default;
            set
            {
            }
        }
    }
}