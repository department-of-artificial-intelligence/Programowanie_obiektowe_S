namespace PO.Lab02
{
    internal class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private List<Grade> _grades;

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

        public List<Grade> Grades
        {
            get { return _grades; }
        }

        public Student()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
            _grades = new List<Grade>();
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _year = year;
            _group = group;
            _indexId = indexId;
            _grades = new List<Grade>();
        }

        public override string ToString()
        {
            DisplayGrades();
            return $"Student | First name: {_firstName}, Last name: {_lastName}, Date of birth: {_dateOfBirth}, Year: {_year}, Group: {_group}, indexId: {_indexId}";
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
            foreach (var grade in _grades)
            {
                Console.WriteLine(grade);
            }
        }

        public void DisplayGrades(string subjectName)
        {
            foreach (var grade in _grades)
            {
                if (grade.SubjectName == subjectName)
                {
                    Console.WriteLine(grade);
                }
            }
        }

        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            _grades.RemoveAll(grade => grade.SubjectName == subjectName && grade.Value == value && grade.Date == date);
        }

        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }

        public void DeleteGrades(string subjectName)
        {
            _grades.RemoveAll(grade => grade.SubjectName == subjectName);
        }

        public void DeleteGrades()
        {
            _grades.Clear();
        }
    }
}