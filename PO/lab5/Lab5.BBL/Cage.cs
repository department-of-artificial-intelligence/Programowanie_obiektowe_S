using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BBL
{
    public class Cage
    {
        private int _id;

        public int Number
        {
            get => default;
            set
            {
            }
        }

        public bool ToClean
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.IList<Animal> Animals
        {
            get => default;
            set
            {
            }
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}