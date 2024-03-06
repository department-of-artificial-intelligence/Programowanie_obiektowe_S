using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class Student : Person
    {
        protected int _year, _group, _indexId;
        private IList<Grade> _grades;
        public int Year
        {
            get => _year;
            set => _year = value;
        }
        public int Group
        {
            get => _group;
            set => _group = value;
        }
        public int IndexId
        {
            get => _indexId;
            set => _indexId = value;
        }
        public IList<Grade> Grades
        {
            get => Grades.ToImmutableList();
        }
        public Student() { }
        public Student(string firstName, string lastName, DateTime date, 
                        int year, int group, int id) 
            : base(firstName, lastName, date)
        {
            Year = year;
            Group = group;
            IndexId = id;
        }

        public override void Details()
        {
            var message = $"Student: {base.ToString()} and other";
            Console.WriteLine(message);
        }
        public void AddGrade(string name, double value, DateTime date)
        {
            var grade = new Grade(name, value, date);
            _grades.Add(grade);
        }
        public void AddGrade(Grade grade)
        {
            if (!_grades.Contains(grade))
            {
                _grades.Add(grade);
            }
        }
    }
}
