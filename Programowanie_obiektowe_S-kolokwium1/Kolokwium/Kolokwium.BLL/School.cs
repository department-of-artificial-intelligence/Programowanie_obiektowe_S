using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class School
    {
        public string Name { get; set; }
        public IList<Lesson> Lessons { get; set; }
        public IList<Teacher> Teachers { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<ClassRoom> ClassRooms { get; set; }
        public IList<Student> Students { get; set; }

        public School (string name, IList<Lesson> lessons, IList<Teacher> teachers, IList<Subject> subjects, IList<ClassRoom> classRooms, IList<Student> students)
        {
            Name = name;
            Lessons = lessons;
            Teachers = teachers;
            Subjects = subjects;
            ClassRooms = classRooms;
            Students = students;
        }

        public ClassRoom CreateClassRoom(int number, int maxCapacity, bool isClean)
        {
            ClassRoom classRoom = new ClassRoom(number, maxCapacity, isClean);
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
            Lesson lesson = new Lesson(classRoom, subject, dayOfWeek, startTime, endTime, teacher);
            Lessons.Add(lesson);
            return lesson;
        }

        public Teacher CreateTeacher(string firstName, string lastName)
        {
            Teacher teacher = new Teacher(firstName, lastName);
            Teachers.Add(teacher);
            return teacher;
        }

        public void AddLessonToTeacher(Lesson lesson, Teacher teacher) 
        {
           teacher.AddLesson(lesson);
        }

        public void AddStudentToLesson(Lesson lesson,Student student)
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
            foreach (Lesson lesson in Lessons)
            {
                if (lesson.Id == id)
                {
                    Lessons.Remove(lesson.id);
                }
            }
        }

        public override string ToString()
        {
            string lessonstr = "";
            string teacherstr = "";
            string subjectstr = "";
            string classroomstr = "";
            string studentstr = "";
            foreach (Lesson lesson in Lessons)
            {
                lessonstr += lesson.ToString() + "\n";
            }
            foreach (Teacher teacher in Teachers)
            {
                teacherstr += teacher.ToString() + "\n";
            }
            foreach(Subject subject in Subjects)
            {
                subjectstr += subject.ToString() + "\n";
            }
            foreach(ClassRoom classRoom in ClassRooms)
            {
                classroomstr += classRoom.ToString() + "\n";
            }
            foreach(Student student in Students)
            {
                studentstr += student.ToString() + "\n";
            }
            return $"{lessonstr} {teacherstr} {subjectstr} {classroomstr} {studentstr}";
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }
    }
}
