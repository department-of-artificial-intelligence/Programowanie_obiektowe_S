using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private static int _idCounter = 1;

        protected int _capacity;
        protected bool _needsCleaning;
        protected IList<Animal> _animals;
        protected int _id;

        public int Capacity
        {
            get => _capacity; set => _capacity = value;
        }

        public bool NeedsCleaning
        {
            get => _needsCleaning; set => _needsCleaning = value;
        }

        public IList<Animal> Animals
        {
            get => _animals; set => _animals = value;
        }

        public int Id
        {
            get => _id; set => _id = value;
        }

        public Animal Animal { get; set; }

        public Cage(int capacity, bool needsCleaning, IList<Animal> animals)
        {
            Id = _idCounter++;
            Capacity = capacity;
            NeedsCleaning = needsCleaning;
            Animals = animals ?? new List<Animal>();
        }

        public override string ToString()
        {
            var animalDescriptions = Animals.Any() ? string.Join("\n  ", Animals.Select(a => a.ToString())) : "  No animals.";
            return $"Cage #{Id} (Capacity: {Capacity}, Needs cleaning: {NeedsCleaning})\n  {animalDescriptions}";
        }
    }
}