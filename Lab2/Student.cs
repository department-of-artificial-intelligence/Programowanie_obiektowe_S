using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace Lab2
{
	public class Student: Person
	{
		private int _year;
		private int _group;
		private int _indexId;
		private List<Grade> _grades = new List<Grade>();

		public int Year{get; set;}
		public int Group { get; set;}
		public int IndexId { get; set;}

		public Student(): base()
		{
			_year = 0;
			_group = 0;
			_indexId = 0;
		}
		public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId): base(firstName, lastName, dateOfBirth)
		{
			_year = year;
			_group = group;
			_indexId = indexId;
		}

		public override string ToString() //Znajdź ładniejszy sposób, aktualne rozwiązanie praktycznie całkowicie ignoruje DisplayGrade w this i Details w Grade.cs
		{
			string zwrot = $"Student | {base.ToString()}, Year: {_year}, Group: {_group}, IndexId: {_indexId} \n";
			foreach (Grade grade in _grades) { 
				zwrot += grade.ToString() ;
			}
			return zwrot;
		}

		public void AddGrade(string subjectName, double value, DateTime date)
		{
			Grade grade = new Grade(subjectName, value, date);
			_grades.Add(grade);
        }
        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }

		public void DisplayGrades()
		{
            foreach (var grade in _grades)
            {
				grade.Details();
            }
		}

		public void DisplayGrades(string subjectName)
		{
			foreach (var grade in _grades)
			{
				if(grade._subjectName == subjectName)
				{
					grade.Details();
				}
			}
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
			_grades.RemoveAll(grade => grade._subjectName.Equals(subjectName));
        }
        public void DeleteGrades()
        {
			_grades.Clear();
        }



    }
}
