using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2DK
{
    public class Student: Person
    {
        private int _year;
        private int _group;
        private int _indexId;

        public int Year { get { return _year; } set { _year = value; } }

        public int Group { get => _group; set => _group = value; }
        public int IndexId { get => _indexId; set => _indexId = value; }

        public Student() : base()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) : base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _indexId = indexId;
        }
        public override string ToString()
        {
            return base.ToString() + $" year: {_year}, group: {_group}, indexId: {_indexId}";
        }
        public override void Details()
        {
            Console.WriteLine(this.ToString() + "\n");
        }
    }
}
