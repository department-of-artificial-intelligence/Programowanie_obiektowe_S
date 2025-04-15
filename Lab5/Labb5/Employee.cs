using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Employee
    {
        public Supervisor Supervisor
        {
            get => default;
            set
            {
            }
        }

        public void Hire()
        {
            throw new System.NotImplementedException();
        }

        public void BuildCage()
        {
            throw new System.NotImplementedException();
        }
    }
}