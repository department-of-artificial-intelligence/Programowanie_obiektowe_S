﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium.BLL
{
    public class Subject : IInfo
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public Subject(string name)
        {
            Name = name;
        }
        public Subject(string name, string description) : this(name)
        {
            Description = description;
        }
        public override string ToString()
        {
            return $"Subject: {Name} | {Description}";
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}