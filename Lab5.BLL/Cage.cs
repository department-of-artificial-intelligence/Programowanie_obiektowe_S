using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private int _id;
        private int _size;
        private bool _needsCleaning;
        private System.Collections.Generic.List<Animal> _animals;

        private static int _nextId = 1;

        public Cage(int size,bool needsCleaning, System.Collections.Generic.List<Animal> animals)
        {
            _id = _nextId++;
            _size = size;
            _needsCleaning = needsCleaning;
            _animals = animals;
        }

        public Animal Animal
        {
            get => default;
            set
            {
            }
        }

        public void Clean()
        {
            _needsCleaning = true;
        }

        public void Expand(int newSize)
        {
            _size = newSize;
        }

        public override string ToString()
        {
            string temp = $"Id: {_id}, Size: {_size}, NeedsCleaning: {_needsCleaning}";
            if(_animals.Count > 0)
            {
                temp += ", Animals:";
                foreach(Animal animal in _animals) { 
                    temp += "\n" + animal.ToString();
                }
                temp += "\n";
            } else
            {
                temp += ", No animals";
            }
            return temp;
        }
    }
}