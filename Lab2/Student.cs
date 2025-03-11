namespace Lab2
{
    class Student : Person
    {
        private int _year;
        private int _group;
        private int _IndexId;
        private IList<Grade>? _grades;

        public int Year { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public IList<Grade>? Grades { get; }

        public Student()
        {
            _year = 0;
            _group = 0;
            _IndexId = 0;
            _grades = new List<Grade>();
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) : base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _IndexId = indexId;
        }

        public override string ToString()
        {
            string allGrades = "";
            if (_grades != null)
                foreach (var grade in _grades)
                    allGrades += grade.ToString();
            return base.ToString() + $"Year: {_year}, Group: {_group}, Index id: {_IndexId}\n" + allGrades;
        }

        public void AddGrade(string subjectName, double value, DateTime date)
        {
            Grade newGrade = new Grade(subjectName, date, value);
            _grades?.Add(newGrade);
        }

        public void AddGrade(Grade grade)
        {
            _grades?.Add(grade);
        }

        public void DisplayGrades()
        {
            if (_grades != null)
                foreach (var grade in _grades)
                    grade.Details();
        }

        public void DisplayGrades(string subjectName)
        {
            if (_grades != null)
                foreach (var grade in _grades)
                    if (grade.SubjectName == subjectName)
                        grade.Details();
        }

        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            Grade newGrade = new Grade(subjectName, date, value);
            _grades?.Remove(newGrade);
        }

        public void DeleteGrade(Grade grade)
        {
            _grades?.Remove(grade);
        }

        public void DeleteGrades(string subjectName)
        {
            if (_grades != null)
                foreach (var grade in _grades)
                    if (grade.SubjectName == subjectName)
                        DeleteGrade(grade);
        }

        public void DeleteGrades()
        {
            _grades?.Clear();
        }
    }
}
