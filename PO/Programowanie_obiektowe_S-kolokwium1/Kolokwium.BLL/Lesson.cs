using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Lesson: IInfo
    {
        private static int objectCounter;
        public int Id { get; set; }
        public Teacher Teacher { get; set; }
        public IList<Student> Students { get; set; }
        public Subject Subject { get; set; }
        public ClassRoom ClassRoom { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public Lesson(ClassRoom classRoom, Subject subject, string dayOfWeek, TimeSpan startTime,TimeSpan endTime,Teacher teacher,IList<Student> students)
        {
            Id = ++objectCounter;
            ClassRoom = classRoom;
            Subject = subject;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
            Students = students;
            Teacher = teacher;
        }
        public override string ToString()
        {
            return Subject.Name;
        }
        public void Display() { 
            var result = $"{Subject.Name}, id { Id}, subject:\n { Subject.ToString()}\nClassroom: { ClassRoom.ToString()}, startTime { StartTime}, endTime { EndTime}, day of week { DayOfWeek}\nStudents on that lesson:\n";
            foreach (Student student in Students) { result += student.ToString() + '\n'; }
            Console.WriteLine(result);
        }
    }
}
