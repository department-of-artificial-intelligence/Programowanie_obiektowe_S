using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;

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

        public Student()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _year = year;
            _group = group;
            _indexId = indexId;
        }

        public override string ToString()
        {
            return $"Person | Student | First name: {_firstName}, Last name: {_lastName}, Date of birth: {_dateOfBirth}, Year: {_year}, Group: {_group}, indexId: {_indexId}";
        }
    }
}
