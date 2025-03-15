namespace Lab2
{
    internal class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private IList<Grade> _grades;

        public int Year {
            get { return _year; }
            set { _year = value; }
        }
        public int Group {
            get { return _group; }
            set { _group = value; }
        }
        public int IndexId {
            get { return _indexId; }
            set { _indexId = value; }
        }
        public Student() : base()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
            _grades = new List<Grade>();
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) : base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _indexId = indexId;
            _grades = new List<Grade>();
        }
        public override string ToString() {
            string details = $"student | {base.ToString()},rok: {_year}, grupa: {_group}, nr. indeksu: {_indexId}, Oceny:\n";
            if (_grades.Count > 0)
            {
                details += "Grades: \n";
            } else {
                details += "Brak Ocen\n";
            }
            foreach (Grade grade in _grades)
            {
                details += "\t" + grade.ToString() + "\n";
            }
            return details;
        }
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
            foreach (Grade grade in _grades)
            {
                Console.WriteLine(grade);
            }
        }
        public void DisplayGrades(string subjectName)
        {
            Console.WriteLine(_grades.Where(grade => grade.SubjectName == subjectName));
        }
        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            _grades.Remove(new Grade(subjectName, value, date));
        }
        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }
        public void DeleteGrades(string subjectName)
        {
            if (_grades is List<Grade> gradesList)
                gradesList.RemoveAll(grade => grade.SubjectName == subjectName);
        }
        public void DeleteGrades() 
        {
            _grades.Clear();
        }
    }
}