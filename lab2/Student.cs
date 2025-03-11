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
        private int _indexID;

        public int Year { get { return _year; } set {  _year = value; } }
        public int Group { get { return _group; } set { _group = value; } }
        public int IndexID { get { return _indexID; } set { _indexID = value; } }

        public Student(string firstName = "none", string lastName = "none", DateTime dateOfBirth = default(DateTime), int year = 999,
                        int group = 999, int indexID = 999)
        :base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _indexID = indexID;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, year = {_year}, group = {_group}, index = {_indexID} ";
        }

    }
}
