using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Employee
    {
        protected string _name;
        protected System.Collections.Generic.List<Cage> _assignedCages;

        public Zoo Zoo
        {
            get => default;
            set
            {
            }
        }
    }
}