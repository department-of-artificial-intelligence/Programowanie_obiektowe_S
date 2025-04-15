using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private int _capacity;
    
        public int Capacity {
            get 
            {
                return _capacity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Capacity must be greater than zero");
                }
                else
                {
                    _capacity = value;
                }
            }
        }
        public bool IsDirty { get; set; }   
        public int UID { get; set; }
        public IList<Animal> Animals { get; set; }

        public Zoo Zoo
        {
            get => default;
            set
            {
            }
        }

        public Cage(int capacity, bool isDirty, IList<Animal> animals) 
        {
            Capacity = capacity;
            IsDirty = isDirty;
            Animals = animals;
        }
    }
}