using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexID;

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


        public int IndexID
        {
            get { return _indexID; }
            set { _indexID = value; }
        }
        public Student()
            :base()
        {
            _year = 0;
            _group = 0;
            _indexID = 0;
        }
        public Student(string firstName, string lastName, DateTime dateTime, int year, int group, int indexId):
            base(firstName, lastName, dateTime)
        {
            _year = year;
            _group = group;
            _indexID = indexId;
        }
        public override string ToString()
        { 
            return base.ToString() + $" Student | Year: {_year}, Group: {_group}, IndexID: {_indexID}"; 
        }
    }
}
