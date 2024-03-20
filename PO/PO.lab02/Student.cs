namespace PO.lab02
{
    using System.Collections.Generic;

    internal class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private List<Grade> _grades = new List<Grade>();




        public int Year { get => _year; set => _year = value; }
        public int Group { get => _group; set => _group = value; }
        public int IndexId { get => _indexId; set => _indexId = value; }

        internal List<Grade> Grades { get => _grades; set => _grades = value; }
        public Student(string firtName, string lastName, DateTime dateOfBirth,
            int year, int group, int indexId) : base(firtName, lastName, dateOfBirth)
        {
            Year = year;
            Group = group;
            IndexId = indexId;
        }

        public Student() : base()
        {
            Year = 0;
            Group = 0;
            IndexId = 0;
        }

        public override string ToString()
        {
            DisplayGrades();
            return $"Student | FirstName: {FirstName}, LastName: {LastName}, Date of Birth: {DateOfBirth}, Year: {Year}, Group: {Group}, Index: {IndexId}\n";
        }


        //Grades
        public void AddGrade(string subjectName, double value, DateTime date)
        {
            _grades.Add(new Grade(subjectName, value, date));
        }

        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }

        public void DisplayGrades()
        {
            foreach (var item in _grades)
            {
                Console.WriteLine(item);
            }
        }

        public void DisplayGrades(string subjectName)
        {
            foreach (var item in _grades)
            {
                if (item.SubjectName == subjectName)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            _grades.RemoveAll(item => item.SubjectName == subjectName && item.Value == value && item.Date == date);
        }

        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }

        public void DeleteGrades(string subjectName)
        {
            _grades.RemoveAll(item => item.SubjectName == subjectName);
        }

        public void DeleteGrades()
        {
            _grades.Clear();
        }

    }
}
