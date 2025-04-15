using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab5.bll
{
    public class Cage
    {
        private int _capacity;
        private bool _needCleaning;
        private int _id;
        private System.Collections.Generic.IList<Animal> animals;

        public bool NeedCleaning { get { return _needCleaning; } set { _needCleaning = value; } }

        public void CageInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}