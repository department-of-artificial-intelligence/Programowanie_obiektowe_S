using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BBL
{
    public class Cage
    {
        private int id;
        public int NumberOfCage
        {
            get;
            set;
        }

        public bool CleanUp
        {
            get;
            set;
        }

        public System.Collections.Generic.List<Animal> AnimalList
        {
            get;
            set;
        }
        public Cage(int numberOfCage, bool cleanUp, List<Animal> animalList)
        { 
            this.NumberOfCage = numberOfCage;
            this.CleanUp = cleanUp;
            this.AnimalList = animalList;
        }
    }
}