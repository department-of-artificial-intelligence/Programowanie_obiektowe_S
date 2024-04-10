using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Lesson
    {
        private static int objectCounter = 0;

        int Id { get; set; }
        public Teacher Teacher { get; set; }
        public IList<Student> Students { get; set; }
        public Subject Subject {  get; set; }
        public ClassRoom ClassRoom { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Lesson(ClassRoom classRoom, Subject subject, string dayOfWeek, TimeSpan startTime, TimeSpan endTime, Teacher teacher, IList<Student> students) 
        {
            ClassRoom = classRoom;
            Subject = subject;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
            Teacher = teacher;
            Students = students;
        }

        public override string ToString()
        {
            return $"{ClassRoom} {Subject} {DayOfWeek} {StartTime} {EndTime} {Teacher} {Students}";
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }
    }
}
