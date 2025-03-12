using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;

        public int Year { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }

        public Student()
            : base()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
            : base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _indexId = indexId;
        }

        public override string ToString() => base.ToString() + $" {Year} {Group} {IndexId}";
    }
}
