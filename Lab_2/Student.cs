using System.ComponentModel.DataAnnotations;

namespace Lab_2
{
    public class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;
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
        public IList<Grade> Grades { get; private set; }
        public Student() : base()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
            Grades = new List<Grade>();
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
            : base(firstName, lastName, dateOfBirth)
        {
            Year = year;
            Group = group;
            IndexId = indexId;
            Grades = new  List<Grade>();
        }
        public override string ToString()
        {
            return $"Student | {base.ToString()}, Year: {_year}, Group: {_group}, IndexId: {_indexId}, Grades: {string.Join("\n",Grades)}";
        }
        public void AddGrade(string subjectName,double value,DateTime date)
        {
            Grades.Add(new Grade(subjectName, value, date));
        }
        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }
        public void DisplayGrades()
        {
            Console.WriteLine(string.Join("\n",Grades));
        }
        public void DisplayGrades(string subjectName)
        {
           foreach (var grade in Grades)
            {
                if (grade.SubjectName == subjectName)
                {
                    Console.WriteLine(grade);
                }

            }
        }
        public void DeleteGrade(string subjectName,double value,DateTime date)
        {
            int index = 0;
            for (int i = 0; i < Grades.Count; i++)
            {
                if (Grades[i].SubjectName == subjectName && Grades[i].Value == value && Grades[i].Date == date)
                {
                    index = i;
                }
            }
            Grades.RemoveAt(index);
           
        }
        public void DeleteGrades(Grade grade)
        {
            Grades.Remove(grade);
        }
        public void DeleteGrades(string subjectName)
        {

            Grades = Grades.Where(grade => grade.SubjectName != subjectName).ToList();//inshyi sposib najty
        }
        public void DeleteGrades()
        {
            Grades.Clear();
        }
    }
}
