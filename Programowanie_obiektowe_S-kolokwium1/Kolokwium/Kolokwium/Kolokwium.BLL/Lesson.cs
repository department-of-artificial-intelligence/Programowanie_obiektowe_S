using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium.BLL
{
    public class Lesson : IInfo
    {
        private static int _objectCounter = 0;

        public int Id {  get; set; }
        public Teacher Teacher { get; set; }
        public IList<Student> Students { get; set; }
        public Subject Subject { get; set; }
        public ClassRoom ClassRoom { get; set; }
        public string DayOfWeek {  get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public Lesson(ClassRoom classRoom, Subject subject, string dayOfWeek, TimeSpan startTime, TimeSpan endTime, Teacher teacher, IList<Student> students)
        {
            Teacher = teacher;
            Students = students;
            ClassRoom = classRoom;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
            Id = GenerateId();
            _objectCounter++;
        }
        public override string ToString()
        {
            string str = $"Lesson: {Id} | {Teacher} | {Subject} | {ClassRoom} | {DayOfWeek} | {StartTime} | {EndTime}";
            if(Students.Count > 0)
            {
                foreach(Student student in Students)
                {
                    str += student.ToString() + "\n";
                }
            }
            return str;
        }
        private int GenerateId()
        {
            Random rand = new Random();
            return rand.Next(0, 9999999);
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}