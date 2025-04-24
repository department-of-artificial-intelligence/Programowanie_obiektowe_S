using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class Cage : IContainer, IDisplayable
    {
        int _idCount = 1;
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
        public Zoo Zoo
        {
            get; set;
        }

        public CageSupervisor CageSupervisor
        {
            get; set;
        }

        public Cage(int capacity, bool needsCleaning, IList<Animal> animals)
        {
            Id = _idCount++;
            Capacity = capacity;
            NeedsCleaning = needsCleaning;
            Animals = animals ?? new List<Animal>();
        }

        public override string ToString()
        {
            string sAnimals = $"animals in cage:";
            foreach(var a in Animals)
            {
                sAnimals += $"\n {a.ToString()}";
            }
            return $"Cage    capacity: {Capacity}, need to clean: {NeedsCleaning}, {sAnimals}";
        }
    }
}