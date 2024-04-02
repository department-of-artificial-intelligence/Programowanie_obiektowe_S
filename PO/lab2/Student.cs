using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Przygotowanie
{
    internal class Student : Person
    {

        private int _year;
        private int _group;
        private int _indexId;
        private IList<Grade> _grades;

        public int Year { get { return _year; } set { _year = value; } }
        public int Group { get { return _group; } set { _group = value; } }
        public int IndexId { get { return _indexId; } set { _indexId = value; } }

        public IList<Grade> Grades { get { return _grades; } }

        public Student() { 
        
            _year = 0;
            _group = 0;
            _indexId = 0;
            _grades = new List<Grade>();

        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
        : base(firstName, lastName, dateOfBirth){ 
        
            _year = year;
            _group = group;
            _indexId = indexId;

        }

        public override string ToString()
        {
            return $"Student | {base.ToString()}, Year {_year}, Group {_group}, IndexId {_indexId}";
        }

        public void AddGrade(string subjectName, double value, DateTime date) { 
        
            Grade grade = new Grade(subjectName, value, date);
            Grades.Add(grade);
        
        
        }

        public void AddGrade(Grade grade) {

            Grades.Add(grade);
        
        }

        public void DisplayGrades() {

            Console.WriteLine($"Grades for student {_firstName} {_lastName}");

            foreach (var grade in Grades) {

                Console.WriteLine(grade);


            }

        }

        public void DisplayGrades(string subjectName) {

            Console.WriteLine($"Grades for {subjectName} for this student");

            foreach (var grade in Grades) {

                if (grade.SubjectName == subjectName) {

                    Console.WriteLine(grade);

                }
            
            }

        }

        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            for (int i = 0; i < Grades.Count; i++)
            {
                if (Grades[i].SubjectName == subjectName && Grades[i].Value == value && Grades[i].Date == date)
                {
                    Grades.RemoveAt(i);
                    Console.WriteLine($"Grade with subject: {subjectName}, value: {value}, date: {date} deleted.");
                    return;
                }
            }
            Console.WriteLine($"Grade with subject: {subjectName}, value: {value}, date: {date} not found.");
        }

        public void DeleteGrade(Grade grade)
        {
            if (Grades.Contains(grade))
            {
                Grades.Remove(grade);
                Console.WriteLine($"Grade with subject: {grade.SubjectName}, value: {grade.Value}, date: {grade.Date} deleted.");
            }
            else
            {
                Console.WriteLine("Grade not found.");
            }
        }

        public void DeleteGrades(string subjectName)
        {
            // Sprawdź czy oceny znajdują się na liście
            if (Grades is List<Grade> gradeList)
            {
                // Usuń wszystkie oceny o podanej nazwie przedmiotu
                gradeList.RemoveAll(grade => grade.SubjectName == subjectName);
                Console.WriteLine($"All grades from {subjectName} deleted.");
            }
            else
            {
                Console.WriteLine("Unable to delete grades. Operation not supported.");
            }
        }

        public void DeleteGrades()
        {
            // Sprawdź czy oceny znajdują się na liście
            if (Grades is List<Grade> gradeList)
            {
                // Wyczyść listę ocen
                gradeList.Clear();
                Console.WriteLine("All grades deleted.");
            }
            else
            {
                Console.WriteLine("Unable to delete grades. Operation not supported.");
            }
        }









    }
}
