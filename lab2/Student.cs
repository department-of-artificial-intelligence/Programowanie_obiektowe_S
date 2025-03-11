using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;

        public Student() 
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth,
                      int year, int group, int indexId) :
                      base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _indexId = indexId;
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int Group
        {
            get { return _group; }
            set { _group = value; }
        }

        public int IndexId
        {
            get { return _indexId; }
            set { _indexId = value; }
        }

        public override string ToString()
        {
            return base.ToString() + 
                    $"Student:| Year: {_year}, Group: {_group}, IndexId: {_indexId} ";
        }
    }
}
