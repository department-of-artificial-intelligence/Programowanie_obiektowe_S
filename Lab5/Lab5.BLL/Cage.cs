﻿using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage : IContainer
    {
        private static int _id = 0;
        private int _capacity;
        private bool _cleaning;

        public int Capacity { get => _capacity; set => _capacity = value; }
        public bool Cleaning { get => _cleaning; set => _cleaning = value; }

        public IList<Animal> Animals { get; set; }

        public Cage(int capacity, bool cleaning, IList<Animal> animals)
        {
            _id++;
            Capacity = capacity;
            Cleaning = cleaning;
            Animals = animals;
        }

        public override string ToString()
        {
            var str = $"Cage: id: {_id}, capacity: {Capacity}, is dirty: {Cleaning}, List of Animal:" +
                $"\n";
            str += string.Join<Animal>('\n', Animals);
            str += '\n';
            return str;
        }


    }
}