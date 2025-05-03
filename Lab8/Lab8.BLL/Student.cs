using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Student : INotifyPropertyChanged
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Faculty { get; set; }
        public int StudentNo { get; set; }
        public IList<Grade> Grades { get; set; } = new List<Grade>();

        public string JoinedGrades
        {
            get => Grades != null ? string.Join(", ", Grades.Select(g => g.ToString())) : "";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Student()
        {
            Firstname = string.Empty;
            Surname = string.Empty;
            Faculty = string.Empty;
            StudentNo = 0;
            Grades = new List<Grade>();
        }

        public Student(string firstname, string surname, string faculty, int studentNo)
        {
            Firstname = firstname ?? string.Empty;
            Surname = surname ?? string.Empty;
            Faculty = faculty ?? string.Empty;
            StudentNo = studentNo;
            Grades = new List<Grade>();
        }
        public Student(string firstname, string surname, string faculty, int studentNo, List<Grade> grades)
        {
            Firstname = firstname ?? string.Empty;
            Surname = surname ?? string.Empty;
            Faculty = faculty ?? string.Empty;
            StudentNo = studentNo;
            Grades = grades ?? new List<Grade>();
        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
            OnPropertyChanged(nameof(Grades));  // Powiadomienie o zmianach w Grades
            OnPropertyChanged(nameof(JoinedGrades));  // Powiadomienie o zmianach w polu JoinedGrades
        }
    }
}
