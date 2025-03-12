using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student: Person
    {
        private int _year;
        private int _group;
        private int _indexId;

        public int Year { get => _year; set => _year = value; }
        public int Group { get => _group; set => _group = value; }

        public int IndexId { get => _indexId; set => _indexId = value; }    

        public Student() { 
            _year = 0;
            _group = 0;
            _indexId = 0;
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId): base(firstName, lastName, dateOfBirth)
        {
            Year = year;
            Group = group;
            IndexId = indexId;
        }
        public override string ToString()
        {
            return $"Student | {base.ToString()} First name: {_firstName} | Last name: {_lastName} | Date of birth: {_dateOfBirth} | Year: {_year} | Group: {_group} | Index: {_indexId}";
        }
    }
}
