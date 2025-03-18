using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace Lab2
{
    public class Student:Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        IList<Grade> _grades=new List<Grade>();
        public int Year { get { return _year; } set { _year = value; } }
        public int Group { get { return _group; } set { _group = value; } }
        public int IndexId { get { return _indexId; } set { _indexId = value; } }
        public IList<Grade> Grades { get { return _grades; } set { _grades = value; } }
        public Student():base()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
        }

        public Student(string firstname,string lastname,DateTime dateofbirth,int year,int group,int index) : base(firstname, lastname, dateofbirth)
        {
            _year = year;
            _group = group;
            _indexId = index;
        }
        public override string ToString()
        {
            string oceny = "";
            foreach(Grade grade in _grades)
            {
                oceny+= grade.ToString();
            }
            return base.ToString()+$"Rok: {_year} Grupa: {_group} Index: {_indexId} "+oceny;
        }
        public void AddGrade(string sn,double v,DateTime d)
        {
            Grade grade = new Grade(sn,v,d);
            _grades.Add(grade);
        }


        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }

        public void DisplayGrades()
        {
            Console.WriteLine(_grades.ToString());
    
        }
        public void DisplayGrades(string sn)
        {
            var grade = _grades.Where(k => k.SubjectName == sn);
            Console.WriteLine(sn.ToString());

        }
        public void DeleteGrade(string sn,double v,DateTime d)
        {
            var gradeToDelete = _grades.FirstOrDefault(g => g.SubjectName == sn && g.Value == v && g.Date == d);
            if (gradeToDelete != null)
            {
                _grades.Remove(gradeToDelete);
            }
        }
        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);

        }
        public void DeleteGrades(string sn)
        {
            var itemsToRemove = _grades.Where(c => c.SubjectName == sn).ToList();

            foreach (var item in itemsToRemove)
            {
                _grades.Remove(item);
            }
        }
        public void DeleteGrades()
        {
            _grades.Clear();
        }


    }
}
