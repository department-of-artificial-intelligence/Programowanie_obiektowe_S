using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        public string Natural
        {
            get;
            set;
        }
        public Mammal() : base()
        {
            Natural = "";
        }
        public Mammal():base()
        {

        }
    }
}