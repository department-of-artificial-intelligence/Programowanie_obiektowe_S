namespace Kolokwium.BBL
{
    public class Lesson : IInfo
    {
        private static int objectCounter = 0;
        public int Id { get; set; }
        public Teacher Teacher { get; set; }
        public IList<Student> Students { get; set; }
        public Subject Subject { get; set; }
        public ClassRoom ClassRoom { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Lesson(ClassRoom classRoom, Subject subject, string dayOfWeek,
                TimeSpan startTime, TimeSpan endTime,
                Teacher teacher, IList<Student> students)
        {
            ClassRoom = classRoom;
            Subject = subject;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
            Teacher = teacher;
            Students = students;

            Id = ++objectCounter;
        }
        public override string ToString()
        {
            return $"Lesson; Id = {Id}";
        }
        public void Display()
        {
            Console.WriteLine(ToString());
            Console.WriteLine(Subject);
            Console.WriteLine(Teacher != null ? Teacher.ToString() : "Doesnt have teacher");
        }
    }
}
