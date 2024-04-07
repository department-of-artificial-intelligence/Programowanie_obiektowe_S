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
            Lessons = new List<Lesson>();
            Subjects = new List<Subject>();
            ClassRooms = new List<ClassRoom>();
        }

        public ClassRoom CreateClassRoom(int number, int maxCapacity, bool isClean)
        {
            IList<int> seats = new List<int>();
            ClassRoom classRoom = new ClassRoom(number, isClean, maxCapacity, seats);
            ClassRooms.Add(classRoom);
            return classRoom;
        }

        public Subject CreateSubject(string name, string description)
        {
            Subject subject = new Subject(name, description);
            Subjects.Add(subject);

            return subject;
        }

        public Lesson CreateLesson(ClassRoom classRoom, Subject subject, string dayOfWeek, TimeSpan startTime, TimeSpan endTime, Teacher teacher)
        {
            IList<Student> students = new List<Student>();
            Lesson lesson = new Lesson(classRoom, subject, dayOfWeek, startTime, endTime, teacher, students);
            Lessons.Add(lesson);
            return lesson;
        }
        
        public Teacher CreateTeacher(string firstName, string lastName)
        {
            IList<Lesson> lessons = new List<Lesson>();
            Teacher teacher = new Teacher(firstName, lastName, lessons);
            Teachers.Add(teacher);
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
            Students.Add(student);
            return student;
        }

        public void RemoveLesson(int id)
        {
            var foundedLesson = Lessons.FirstOrDefault(b => b.Id == id);
            Lessons.Remove(foundedLesson);
        }

        public override string ToString()
        {
            var str1 = $"Name: {Name} \n";
            var str2 = string.Join<Lesson>('\n', Lessons);
            //var str3 = string.Join<Teacher>('\n', Teachers);
            //var str4 = string.Join<Subject>('\n', Subjects);
            //var str5 = string.Join<ClassRoom>('\n', ClassRooms);
            //var str6 = string.Join<Student>('\n', Students);
            return $"{str1} \n + {str2} \n ";
        }

        public void Display()
        {
            Console.WriteLine(this);
        }

    }
}
