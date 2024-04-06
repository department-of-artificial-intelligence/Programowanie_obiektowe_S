using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Przygotowanie.BLL
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
        }

        public ClassRoom CreateClassRoom(int number, int maxCapacity, bool isClean)
        {
            IList<int> seats = new List<int>();
            ClassRoom classRoom = new ClassRoom(number, isClean, maxCapacity, seats);
            return classRoom;
        }

        public Subject CreateSubject(string name, string description)
        {
            Subject subject = new Subject(name, description);
            return subject;
        }

        public Lesson CreateLesson(ClassRoom classRoom, Subject subject, string dayOfWeek, TimeSpan startTime, TimeSpan endTime, Teacher teacher)
        {
            IList<Student> students = new List<Student>();
            Lesson lesson = new Lesson(classRoom, subject, dayOfWeek, startTime, endTime, teacher, students);
            return lesson;
        }
        
        public Teacher CreateTeacher(string firstName, string lastName)
        {
            IList<Lesson> lessons = new List<Lesson>();
            Teacher teacher = new Teacher(firstName, lastName, lessons);
            return teacher;
        }

        public void AddLessonToTeacher(Lesson lesson, Teacher teacher)
        {
            teacher.AddLesson(lesson);
        }

        public void AddStudentToLesson(Lesson lesson, Student student)
        {
            lesson.Students.Add(student);
        }

        public Student CreateStudent(string firstName, string lastName, int year, int group, int indexId)
        {
            Student student = new Student(firstName, lastName, year, group, indexId);
            return student;
        }

        public void RemoveLesson(int id)
        {
            var foundedLesson = Lessons.Where(b => b.Id == id);
            Lessons.Remove((Lesson)foundedLesson);
        }

        public override string ToString()
        {
            var str = $"Name: {Name} \n";
            str += string.Join<Lesson>('\n', Lessons);
            str += string.Join<Teacher>('\n', Teachers);
            str += string.Join<Subject>('\n', Subjects);
            str += string.Join<ClassRoom>('\n', ClassRooms);
            str += string.Join<Student>('\n', Students);
            return str;
        }

        public void Display()
        {
            Console.WriteLine(this);
        }

    }
}
