using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private int _capacity;
        public int _id;
        private bool _isClean;

        public Cage(int capacity, bool isClean)
        {
            _capacity = capacity;
            _id = _id+1;
            _isClean = isClean;
        }
    }
}