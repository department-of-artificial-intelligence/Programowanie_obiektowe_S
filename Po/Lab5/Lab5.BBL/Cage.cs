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
        public int Id
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
        public override string ToString()
        {
            string animal = string.Join(", ", AnimalList.Select(a=>a.ToString()));
            return $"ID: {Id}, Cage size: {NumberOfCage}, Clean Up: {CleanUp}, Animal: {animal}";
        }
    }
}