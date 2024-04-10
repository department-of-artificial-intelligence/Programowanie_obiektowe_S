using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium.BLL
{
    public class School : IInfo
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
            Teachers = teachers;
            Students = students;
            Subjects = new List<Subject>();
            ClassRooms = new List<ClassRoom>();
            Lessons = new List<Lesson>();
        }
        public ClassRoom CreateClassRoom(int number, int maxcap, bool isclean)
        {
            ClassRoom classRoom = new ClassRoom(number, maxcap, isclean);
            ClassRooms.Add(classRoom);
            return ClassRooms[ClassRooms.Count - 1];
        }
        public Subject CreateSubject(string name, string desc)
        {
            Subject subject = new Subject(name, desc);
            Subjects.Add(subject);
            return Subjects[Subjects.Count - 1];
        }
        public Lesson CreateLesson(ClassRoom classroom, Subject sub, string DOW, TimeSpan starttime, TimeSpan endtime, Teacher teacher)
        {
            Lesson lesson = new Lesson(classroom, sub, DOW, starttime, endtime, teacher, new List<Student>());
            Lessons.Add(lesson);
            return Lessons[Lessons.Count - 1];
        }
        public Teacher CreateTeacher(string FName, string LName)
        {
            Teacher tea = new Teacher(FName, LName, new List<Lesson>());
            Teachers.Add(tea);
            return Teachers[Teachers.Count - 1];
        }
        public void AddLessonToTeacher(Lesson lesson, Teacher tea)
        {
            tea.Lessons.Add(lesson);
        }
        public void AddStudentToLesson(Lesson les, Student stud)
        {
            les.Students.Add(stud);
        }
        public Student CreateStudent(string FName, string LName, int year, int group, int indexid)
        {
            Student stud = new Student(FName, LName, year, group, indexid);
            Students.Add(stud);
            return stud;
        }
        public void RemoveLesson(int id)
        {
            try
            {
                Lessons.Remove(Lessons.FirstOrDefault(c => c.Id == id));
            }
            catch
            {
                Console.WriteLine("NULL REF removelesson COUGHT!!");
            }

        }
        public override string ToString()
        {
            string str = $"School: {Name} which includes in itself: \n";
            if(Lessons.Count > 0)
            {
                foreach(var lesson in Lessons)
                {
                    str += lesson.ToString() + "\n";
                }
            }
            if (Teachers.Count > 0)
            {
                foreach (var tea in Teachers)
                {
                    str += tea.ToString() + "\n";
                }
            }
            if (Subjects.Count > 0)
            {
                foreach (var sub in Subjects)
                {
                    str += sub.ToString() + "\n";
                }
            }
            if (ClassRooms.Count > 0)
            {
                foreach (var CLR in ClassRooms)
                {
                    str += CLR.ToString() + "\n";
                }
            }
            if (Students.Count > 0)
            {
                foreach (var std in Students)
                {
                    str += std.ToString() + "\n";
                }
            }
            return str;
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}