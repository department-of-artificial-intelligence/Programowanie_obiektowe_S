using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.bll
{
    public class Cage : IContainer, IDisplayable
    {
        public int Capacity;
        private int _id;
        public bool IsCageDirty;
        public IList<Animal> Animals;

        public void CleanCage()
        {
            Console.WriteLine("Cleaning Cage");
            IsCageDirty = false;
        }
        public Cage(int capacity, bool isCageDirty, IList<Animal> animals)
        {
            Capacity = capacity;
            IsCageDirty = isCageDirty;
            Animals = animals;
        }
        public override string ToString()
        {
            string zwierzeta = "";
            foreach(Animal animal in Animals)
            {
                zwierzeta += animal;
            }
            return $"Capacity: {Capacity} Animals: {zwierzeta}";
        }
    }
}