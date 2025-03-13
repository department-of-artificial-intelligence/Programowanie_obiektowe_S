using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2
{
    internal class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private IList<Grade> _grades = new List<Grade>();

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

        public IList<Grade> Grades
        {
            get { return _grades; }
        }


        public Student()
            :base()
        {
            _year = 0;
            _group = 0; 
            _indexId = 0;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId):
            base(firstName, lastName, dateOfBirth)
        {
            _year = year;       
            _group =group;
            _indexId = indexId;
        }

        public override string ToString()
        {
            return base.ToString() + $", year: {_year}, group: {_group}, indexId: {_indexId}";
        }

        public override void Details()
        {
            Console.WriteLine("Student | "+ToString());
            foreach(var grade in _grades)
            {
                grade.Display();
            }
        }

        //metody do zarzadzania ocenami:
        public void AddGrade(string subjectName, double value, DateTime date)
        {
            Grade ocena = new Grade(subjectName, value, date);
            _grades.Add(ocena);
        }

        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }

        public void DisplayGrades()
        {
            foreach(var grade in _grades)
            {
                grade.Display();
            }
        }

        public void DisplayGrades(string subjectName)
        {
            foreach(var grade in _grades)
            {
                if(grade.SubjectName == subjectName)
                {
                    grade.Display();
                }
            }
        }

        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            bool flaga = true;
            

            for(int i = _grades.Count-1; i >= 0; i--)
            {
                if (_grades[i].SubjectName == subjectName && _grades[i].Value == value && _grades[i].Date == date)
                {
                    _grades.RemoveAt(i);
                    flaga = false;
                    Console.WriteLine("Poprawnie usunieto ocene");
                    break;
                }
            }
            
            if (flaga)
            {
                Console.WriteLine("Nie znaleziono takiej oceny");
            }
        }

        public void DeleteGrade(Grade grade)
        {
            bool flaga = true;


            for (int i = _grades.Count-1; i >=0; i--)
            {
                if (_grades[i].SubjectName == grade.SubjectName && _grades[i].Value == grade.Value && _grades[i].Date == grade.Date)
                {
                    _grades.RemoveAt(i);
                    flaga = false;
                    Console.WriteLine("Poprawnie usunieto ocene");
                    break;
                }
            }

            if (flaga)
            {
                Console.WriteLine("Nie znaleziono takiej oceny");
            }
        }

        public void DeleteGrades(string subjectName)
        {
            for (int i =_grades.Count - 1; i >= 0; i--)
            {
                if (_grades[i].SubjectName == subjectName)
                {
                    _grades.RemoveAt(i);
                }
            }
            Console.WriteLine("Operacja zakonczona");
        }

        public void DeleteGrades()
        {
            _grades.Clear();
        }
    }
}
