namespace Kolokwium.BBL
{
    internal class School
    {

        public string Name { get; set; }
        public IList<Lesson> Lessons { get; set; }
        public IList<Teacher> Teachers { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<ClassRoom> ClassRooms { get; set; }
        public IList<Student> Students { get; set; }

        public School(string name, IList<Student> students, IList<Teacher> teachers)
        {

            Name = name;
            Students = students;
            Teachers = teachers;

            ClassRooms = new List<ClassRoom>();
            Lessons = new List<Lesson>();
            Subjects = new List<Subject>();

        }

        /* public ClassRoom CreateClassRoom(int number, int maxCapacity, bool isClean)
         {

             ClassRoom = new ClassRoom(number, maxCapacity, isClean);

             return ClassRoom;

         }
        */

        public Subject CreateSubject(string name, string description)
        {

            Subject subject = new Subject(name, description);

        }

        public Lesson CreateLesson(ClassRoom classRoom, Subject subject, string dayOfWeek, TimeSpan startTime, TimeSpan endTime, Teacher teacher) { }

        public Teacher CreateTeacher(string firstName, string lastName)
        {

        }

        public void AddLessonToTeacher(Lesson lesson, Teacher teacher) { }
        public void AddStudentToLesson(Lesson lesson, Student student) { }
        public Student CreateStudent(string firstName, string lastName, int year, int group, int indexId) { }
        public void RemoveLesson(int id) { }


    }
}
