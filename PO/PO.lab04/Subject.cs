﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab04
{
    public class Subject
    {
        public string Name { get; set; }
        public string Specialization{ get; set; }
        public int Semester { get; set; }
        public int HoursCount {  get; set; }
        public Subject(string name, string specialization, int semester, int hoursCount) 
        {
            Name = name;
            Specialization = specialization;
            Semester = semester;
            HoursCount = hoursCount;
        }
        public override string ToString()
        {
            return $"Name: {Name} | Specialization {Specialization} | Sumeseter: {Semester} | Count of Hours: {HoursCount}";
        }
    }
}
