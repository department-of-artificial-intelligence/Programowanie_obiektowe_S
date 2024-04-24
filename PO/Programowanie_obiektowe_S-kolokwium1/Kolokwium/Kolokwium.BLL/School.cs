using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    class School: IInfo
    {
        public string Name { get; set; }
        public IList<Lesson> Lessons {get; set;}
        public IList<Subject> Subjects { get; set; }
        public IList<Teacher> Teachers { get; set; }
        public IList<ClassRoom> Classrooms { get; set; }
        public IList<Student> Students { get; set; }
        public School(string name, IList<Student> students, IList<Teacher> teachers)
        {
            Name = name;
            Students = students;
            Teachers = teachers;
            Classrooms = new List<ClassRoom>();
            Students = new List<Student>();
            Lessons = new List<Lesson>();
        }
        public ClassRoom CreateClassRoom(int number, int maxCapacity,bool isClean)
        {
            new ClassRoom (number, maxCapacity, isClean);
            return ClassRoom;
        }
        public Lesson CreateLesson(ClassRoom classRoom,Subject subject,string  dayOfWeek, TimeSpan startTime, TimeSpan endTime,Teacher teacher) { }
        {
       
        }
    public Teacher CreateTeacher ( string firstname,  string lastname)
    {

    }
    public Subject CreateSubject(string name, string description)
    {

    }
    public  void AddLessonToTeacher ( Lesson lesson, Teacher teacher)
    {
        Lessons.Add(i => i.Teacher == teacher);
    }
    public void AddStudentToLesson(Lesson lesson, Student student)
    {
        Students.Add(i => i.Lessons == lesson);
    }
    public Student CreateStudent(string firstname, string lastname, int year, int group, int indexId) { }

    public override string ToString()
    {
        string res = $"Name: {Name}, \n Lessons:";
        foreach (var lesson in Lessons)
        {
            res += lesson+"\n" ;
        }
        foreach (var sub in Subjects)
        {
            res +="Subject: "+ sub+ "\n" ;
        }
        foreach (var t in Teachers)
        {
            res += "Teacher: "+t+ "\n" ;
        }
        foreach (var c in ClassRooms)
        {
            res +="ClassRooms: "+ c + "\n" ;
        }
        foreach(var s in Students){
            res+= "Students: "+ s + "\n";
        }
        return res;
    }
    public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
