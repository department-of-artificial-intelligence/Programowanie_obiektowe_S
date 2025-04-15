using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab5.bll
{
    public class Bird : Animal
    {
        private int _durability;
        private int _wingsLength;

        public Bird()
        {
            throw new System.NotImplementedException();
        }

        public int Fly()
        {
            return _durability * _wingsLength;
        }
    }
}