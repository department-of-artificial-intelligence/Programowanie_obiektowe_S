using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Employee
    {
        public System.Collections.Generic.List<Cage> Cages
        {
            get => default;
            set
            {
            }
        }

        public void CleanCage()
        {
            throw new System.NotImplementedException();
        }
    }
}