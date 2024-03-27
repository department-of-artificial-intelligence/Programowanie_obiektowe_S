using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        public int _rozpecie;
        public int _wytszymalosc;
        int fly()
        {
            return _rozpecie* _wytszymalosc;
        }
    }
}