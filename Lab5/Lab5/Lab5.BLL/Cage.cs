using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private int _capacity;
        private bool _needCleaning;
        private int _id;
        private System.Collections.Generic.IList<Animal> Animals;

        public Animal Animal
        {
            get => default;
            set
            {
            }
        }
    }
}