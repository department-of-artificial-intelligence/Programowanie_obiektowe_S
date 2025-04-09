using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Animal
    {
        private string _specie;
        private string _foodType;
        private string _origin;
        private int _number;

        public Animal(string foodType, int number, string origin, string specie)
        {
            _specie=specie;
            _number=number;
            _foodType=foodType;
            _origin=origin;
        }
    }
}