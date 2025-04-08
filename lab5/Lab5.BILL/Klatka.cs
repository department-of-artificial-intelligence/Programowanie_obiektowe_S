using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gosha
{
    public class Cage
    {
        public int Capacity { get; set; }
        public bool NeedCleaning {  get; set; }
        public List<Animal> Animals { get; set; }
        public Cage(int capacity, bool needCleaning, List<Animal> animals) {
            Capacity = capacity;
            NeedCleaning = needCleaning;
            Animals = animals;

        }
        public override string ToString()
        {
            return $"Cage (Capacity: {Capacity}, Needs Cleaning: {NeedCleaning}, Animals: {Animals.Count}";
        }
    }
}