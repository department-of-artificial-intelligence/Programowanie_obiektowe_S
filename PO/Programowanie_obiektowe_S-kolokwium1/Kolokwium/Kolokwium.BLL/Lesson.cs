using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    class Lesson: IInfo
    {
           private static int objectCounter;

        public int Id  { get; set; }
        public Teacher Teacher { get; set; }
        public IList<Student> Students { get; set; }
        public Subject Subject { get; set; }
        public ClassRoom Classroom { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Lesson(ClassRoom classRoom,Subject subject,string dayofWeek, TimeSpan startTime, TimeSpan endTime, Teacher teacher, IList<Student> students)
        {
            Classroom = classRoom;
            Subject = subject;
            DayOfWeek = dayofWeek;
            StartTime = startTime;
            EndTime = endTime;
            Teacher = teacher;
            Students = students;
            objectCounter++;
        }
        public override string ToString()
        {
            string res = $"ClassRoom: {Classroom}\n Subject: {Subject}\nDayofWeek: {DayOfWeek}, StartTime: {StartTime}, EndTime:{EndTime}\n Students:\n  ";
            foreach(Student student in Students)
            {
                res += "\t"+ student +"\n" ;
            }
            return res ;
        }
        public void Display()
            {
                Console.WriteLine(this);
            }
    }
}
