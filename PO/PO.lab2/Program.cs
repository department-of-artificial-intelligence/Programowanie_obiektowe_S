﻿using System;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Numerics;

namespace PO.lab2
{

    
    

    


    class Program
    {
        static void Main(string[] args )
        {
            Person person1 = new Person("Adam", "Miś", new DateTime(1990, 3, 20, 12, 30, 10));
            Person person2 = new Student("Michał", "Kot", new DateTime(1990, 4, 13), 3, 5, 12345);
            Person person3 = new Player("Robert", "Lewandowski", new DateTime(1988, 10, 3), "Striker", "Bayern", 41);
            person1.Details();
            person2.Details();
            person3.Details();
            Student student = new Student("Krzysztof", "Jeż", new DateTime(1990, 12, 29), 2, 5, 54321);
            student.Details();
            ((Player)person3).ScoreGoal();
            person3.Details();
        }
    }
}