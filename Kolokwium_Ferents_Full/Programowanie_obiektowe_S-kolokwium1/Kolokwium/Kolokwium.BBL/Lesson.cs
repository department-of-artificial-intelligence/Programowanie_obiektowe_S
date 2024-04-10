using System.Text;

namespace Kolokwium.BBL
{
    internal class Lesson
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

        public Lesson(ClassRoom classRoom, Subject subject, string dayOfWeek, TimeSpan startTime, TimeSpan endTime, Teacher teacher, IList<Student> students)
        {


            this.ClassRoom = classRoom;
            this.Subject = subject;
            this.DayOfWeek = dayOfWeek;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Students = students;
            this.Teacher = teacher;

        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Students: ");

            foreach (var item in Students)
            {

                sb.AppendLine(item.ToString());

            }

            return $"Clasroom {ClassRoom}, Subject {Subject}, DayOfWeek {DayOfWeek}, StartTime {StartTime}, EndTime {EndTime}, Teacher {Teacher}, {sb.ToString()} ";
        }

        public void Display()
        {

            Console.WriteLine(ToString());

        }

    }
}
