using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    internal class Lesson : IInfo
    {
        private static int _objectCounter;

        public int Id { get; set; }
        public Teacher Teacher { get; set; }
        public IList<Student> Students { get; set; }
        public Subject Subject { get; set; }
        public ClassRoom ClassRoom { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public Lesson(ClassRoom classRoom, Subject subject, string dayOfWeek, TimeSpan startTime, TimeSpan endTime, Teacher teacher, IList<Student> students)
        {
            Id = 0;
            Teacher = teacher;
            Students = students;
            Subject = subject;
            ClassRoom = classRoom;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            string s = new string($"ID: {Id} Teacher: {Teacher} Students: \n");
            foreach (var item in Students)
            {
                s += item.ToString() + "\t\t";
            }
            s += $"Subject: {Subject} Class Room: {ClassRoom} Day of Week: {DayOfWeek} Start Time: {StartTime} End Time: {EndTime}";
            return s;
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }
    }
}
