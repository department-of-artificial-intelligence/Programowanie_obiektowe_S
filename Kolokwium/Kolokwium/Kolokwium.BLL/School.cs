using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    internal class School : IInfo
    {
        public string Name { get; set; }
        public IList<Lesson> Lessons { get; set; }
        public IList<Teacher> Teachers { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<ClassRoom> ClassRooms { get; set; }
        public IList<Student> Students { get; set; }

        public School(string name, IList<Student> students, IList<Teacher> teachers)
        {
            Name = name;
            Lessons = new List<Lesson>();
            Teachers = teachers;
            Subjects = new List<Subject>();
            ClassRooms = new List<ClassRoom>();
            Students = students;
        }

        public ClassRoom? CreateClassRoom(int number, int maxCapacity, bool isClean)
        {
            foreach (var item in ClassRooms)
            {
                if (item.Number != number && item.MaxCapacity != maxCapacity && item.IsClean != isClean)
                {
                    ClassRooms.Add(item);
                }
            }
            return null;
        }

        public Subject? CreateSubject(string name, string description)
        {
            foreach (var item in Subjects)
            {
                if (item.Name != name && item.Description != description)
                {
                    Subjects.Add(item);
                }
            }
            return null;
        }

        public Lesson? CreateLesson(ClassRoom classRoom, Subject subject, string dayOfWeek, TimeSpan startTime, TimeSpan endTime, Teacher teacher)
        {
            foreach (var item in Lessons)
            {
                if(item.ClassRoom != classRoom && item.Subject != subject && item.DayOfWeek != dayOfWeek && item.Teacher != teacher) 
                {
                    Lessons.Add(item);
                }
            }
            return null;
        }

        public Teacher? CreateTeacher(string firstName, string lastName)
        {
            foreach (var item in Teachers)
            {
                if (item.FirstName != firstName && item.LastName != lastName)
                {
                    Teachers.Add(item);
                }
            }
            return null;
        }

        public void AddLessonToTeacher(Lesson lesson, Teacher teacher)
        {
            foreach (var item in Teachers)
            {
                if (!item.Lessons.Contains(lesson))
                {
                    Teachers.Add(item);
                }
            }
        }

        public void AddStudenttoLesson(Lesson lesson, Student student)
        {
            foreach (var item in Lessons)
            {
                if (!item.Students.Contains(student))
                {
                    Lessons[0].Students.Add(student);
                }
            }
        }

        public Student? CreateStudent(string firstName, string lastName, int year, int group, int indexId)
        {
            foreach (var item in Students)
            {
                if (item.IndexId != indexId)
                {
                    Students.Add(item);
                }
            }
            return null;
        }

        public void RemoveLesson(int id)
        {
            foreach (var item in Lessons)
            {
                if (item.Id == id)
                {
                    Lessons.Remove(item);
                }

            }
        }

        public override string ToString()
        {
            string s = new string($"School: {Name} Lessons: \n");
            foreach (var item in Lessons)
            {
                s += item.ToString() + "\n";
            }
            s += $"Teachers: \n";
            foreach (var item in Teachers)
            {
                s += item.ToString() + "\n";
            }
            s += $"Subjects: \n";
            foreach (var item in Lessons)
            {
                s += item.ToString() + "\n";
            }
            s += $"ClassRooms: \n";
            foreach (var item in ClassRooms)
            {
                s += item.ToString() + "\n";
            }
            s += $"Students: \n";
            foreach (var item in Students)
            {
                s += item.ToString();
            }
            return s;
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }
    }
}
