using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab02
{
    internal class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;

        

        public int Year { get { return _year; } set { _year = value; } }
        public int Group { get { return _group; } set { _group = value; } }
        public int IndexId { get { return _indexId; } set { _indexId = value; } }

        public Student(string firtName, string lastName, DateTime dateOfBirth, 
            int year, int group, int indexId) : base(firtName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _indexId = indexId;
        }

        public Student() : base()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
        }

        public override string ToString()
        {
            return $"Student | FirstName: {FirstName}, LastName: {LastName}, Date of Birth: {DateOfBirth}, Year: {Year}, Group: {Group}, Index: {IndexId}";
        }
    }
}
