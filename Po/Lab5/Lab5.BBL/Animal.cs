﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BBL
{
    public class Animal
    {
        public string Name
        {
            get;
            set;
        }

        public int NumberOfLegs
        {
            get;
            set;
        }

        public string Nutrition
        {
            get;
            set;
        }

        public string Origin
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Number Of Legs: {NumberOfLegs}, Nutrition: {Nutrition}, Origin: {Origin}";
        }

        public Animal(string name, int numberOfLegs,string nutrition,string origin) { 
        
            Name = name;
            NumberOfLegs = numberOfLegs;
            Nutrition = nutrition;
            Origin = origin;
        }

    }
}