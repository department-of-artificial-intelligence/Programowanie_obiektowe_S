namespace lab2
{
    internal class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private List<Grade> _grades = new List<Grade>();

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
        public Student() : base()
        {
            Year = 0;
            Group = 0;
            IndexId = 0;

        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) : base(firstName, lastName, dateOfBirth)
        {
            Year = year;
            Group = group;
            IndexId = indexId;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, DateOfBirth: {DateOfBirth}, Year: {Year}, Group: {Group}, IndexId: {IndexId}";
        }

        public void AddGrade(string subjectName, double value, DateTime date)
        {
            Grades.Add(new Grade(subjectName, value, date));
        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }

        public void DisplayGrades()
        {

        }

        public void DisplayGrades(string subjectName)
        {

        }
        public void DeleteGrade(string subjectName, double value, DateTime date)
        {

        }
        public void DeleteGrade(Grade grade)
        {

        }
        public void DeleteGrades(string subjectName)
        {

        }
        public void DeleteGrades()
        {

        }
    }
}
