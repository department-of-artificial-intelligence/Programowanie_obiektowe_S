using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kolokwium.BLL
{
    public class School: IInfo
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
            Students = students;
            Teachers = teachers;
            Subjects = new List<Subject>();
            ClassRooms = new List<ClassRoom>();
            Lessons = new List<Lesson>();
        }
        public ClassRoom CreateClassRoom(int number, int maxCapacity,bool isClean)
        {
            var newRoom = new ClassRoom(number, maxCapacity, isClean);
            ClassRooms.Add(newRoom);
            return newRoom;
        }
        public Subject CreateSubject(string name,string description)
        {
            var newSubject = new Subject(name,description);
            Subjects.Add(newSubject);
            return newSubject;
        }
        public Lesson CreateLesson(ClassRoom classRoom, Subject subject, string dayOfWeek, TimeSpan startTime, TimeSpan endTime, Teacher teacher)
        {
            var newLesson = new Lesson(classRoom,subject, dayOfWeek, startTime, endTime, teacher,new List<Student>());
            Lessons.Add(newLesson);
            return newLesson;
        }
        public Teacher CreateTeacher(string firstName, string lastName)
        {
            var newTeacher = new Teacher(firstName, lastName,new List<Lesson>());
            Teachers.Add(newTeacher);
            return newTeacher;
        }
        public void AddLessonToTeacher(Lesson lesson, Teacher teacher)
        {
            lesson.Teacher = teacher;
            teacher.AddLesson(lesson);
        }
        public void AddStudentToLesson(Lesson lesson,Student student)
        {
            lesson.Students.Add(student);
        }
        public Student CreateStudent(string firstName, string lastName, int year, int group, int indexId) 
        {
            var newStudent = new Student(firstName, lastName, year, group, indexId);
            Students.Add(newStudent);
            return newStudent;
        }
        public void RemoveLesson(int id) { Console.WriteLine(Lessons.Remove(Lessons.First(o => o.Id == id))); }
        public override string ToString()
        {
            return $"School {Name}";
        }
        public void Display()
        {
            Console.WriteLine(ToString());
            Console.WriteLine("Lessons: ");
            foreach (var lesson in Lessons)
                lesson.Display();
            Console.WriteLine("Teachers: ");
            foreach (var teacher in Teachers)
                teacher.Display();
            Console.WriteLine("Subjects: ");
            foreach (var subject in Subjects)
                subject.Display();
            Console.WriteLine("ClassRooms: ");
            foreach (var classRoom in ClassRooms)
                classRoom.Display();
            Console.WriteLine("Students: ");
            foreach (var student in Students)
                student.Display();
        }
    }
}
