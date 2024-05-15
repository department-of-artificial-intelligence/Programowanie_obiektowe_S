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
        public event PropertyChangedEventHandler PropertyChanged;

        public string? FirstName { get; set; }
        public string? SurName { get; set; }
        public string? Faculty { get; set; }
        public int StudentNo { get; set; }
        private List<Grade> grades;
        public List<Grade> Grades
        {
            get { return (List<Grade>)grades; }
            set
            {
                grades = value;
                OnPropertyChanged(nameof(Grades));
                OnPropertyChanged(nameof(GradesString)); // Notify that GradesString has changed when Grades changes
            }
        }
        public Student(string firstName,string surName, string faculty, int studentNo) 
        {
            FirstName = firstName;
            SurName = surName;
            Faculty = faculty;
            StudentNo = studentNo;

        }
        public Student(string firstName, string surName, string faculty, int studentNo,IList<Grade> grades12)
        {
            FirstName = firstName;
            SurName = surName;
            Faculty = faculty;
            StudentNo = studentNo;
            Grades = (List<Grade>)grades12;
        }
        public Student() 
        {
            FirstName = null;
            SurName = null;
            Faculty = null;
            StudentNo = 0;

        }




        public string GradesString
        {
            get
            {
                if (Grades != null)
                    return string.Join(", ", Grades.Select(g => g.GradeS));
                else
                    return "";
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public override string ToString()
        {
            string g = string.Join(", ", Grades.Select(a=>a.ToString()));
            return $"First Name {FirstName}, Sur Name {SurName}, Faculty {Faculty}, Grades {g}";
        }
    }
}
