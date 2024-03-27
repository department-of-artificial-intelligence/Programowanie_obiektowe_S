using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private static int countCages = 0;
        protected int _capacity;
        protected bool _isDirty;
        protected int _id;
        public int Capacity
        {
            get => _capacity;
            set {
                if(value!=0)
                    _capacity = value;
            }
        }

        public bool IsDirty
        {
            get => _isDirty;
            set=> _isDirty = value;
        }

        public List<Animal> Animals { get; set; }

        public Cage(int capacity, bool isDirty, List<Animal> animals)
        {
            countCages++;
            _id = countCages;
            Animals = animals;
            Capacity = capacity;
            IsDirty = isDirty;
        }
        public override string ToString()
        {
            string res = $"{Capacity} {IsDirty} || Cages:\n";
            foreach (var item in Animals)
            {
                res += "\t" + item + "\n";
            }
            return res;
        }
    }
}