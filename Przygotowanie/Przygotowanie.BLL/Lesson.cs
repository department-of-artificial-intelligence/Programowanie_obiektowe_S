using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przygotowanie.BLL
{
    public class Lesson : IInfo
    {
        private static int _objectCounter = 0;

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
            Teacher = teacher;
            Students = students;
            Subject = subject;
            ClassRoom = classRoom;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
            _objectCounter++;
        }

        public override string ToString()
        {
            var str = $"Id: {Id} \n";
            str += Teacher.ToString();
            str += string.Join<Student>('\n', Students);
            str += Subject.ToString();
            str += ClassRoom.ToString();
            str += $"day of week: {DayOfWeek}, Start time: {StartTime}, end time: {EndTime}";
            return str;
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
