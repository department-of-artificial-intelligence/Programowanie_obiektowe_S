using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private int _capacity;
        private bool _cleaning;
        /// <summary></summary>
        private int _id;

        public int Capacity { get => _capacity; set => _capacity = value; }
        public bool Cleaning { get => _cleaning; set => _cleaning = value; }
    }
}