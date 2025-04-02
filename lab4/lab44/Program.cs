using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab44 {
    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirt { get; set; }
        public Person() { }
        public Person(string firstName, string lastName, DateTime dateOfBirt) {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirt = dateOfBirt;
        }

        public override string ToString() {
            return $"FirstName: {FirstName}, LastName: {LastName}, DateOfBirth: {DateOfBirt} ";
        }
    }

    public class Student {
        private int id;

    }


        class FinalGrade {
        public Subject Subject { get; set; }    
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public FinalGrade(Subject subject, double value, DateTime date) {
            Subject= subject;
            Date= date;
            Value= value;
        }
        public override string ToString() {
            return $"Subject: {Subject}, Data: {Date}, Value: {Value} ";
        }
    }
    class Subject {
        public string Name { get; set; }

        public string Specjalization { get; set; }

        public int Semester { get; set; }

        public int HoursCount { get; set; }

        public Subject() { }

        public Subject(string name, string specjalization,
            int semester, int hourscount) {
            Name = name;
            Specjalization = specjalization;
            Semester = semester;
            HoursCount = hourscount;

        }

        public override string ToString() {
            return $"Name: {Name}, Specjalization: {Specjalization}, Semester: {Semester}, HoursCount: {HoursCount}";
        }
    }
    }
