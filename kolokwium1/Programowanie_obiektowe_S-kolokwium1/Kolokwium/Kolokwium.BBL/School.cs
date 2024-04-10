namespace Kolokwium.BBL
{
    public class School : IInfo
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

            Lessons = new List<Lesson>();
            Subjects = new List<Subject>();
            ClassRooms = new List<ClassRoom>();
        }

        public ClassRoom CreateClassRoom(int number, int maxCapacity, bool isClean)
        {
            var room = new ClassRoom(number, maxCapacity, isClean);
            ClassRooms.Add(room);
            return room;
        }

        public Subject CreateSubject(string name, string description)
        {
            var subject = new Subject(name, description);
            Subjects.Add(subject);
            return subject;
        }

        public Lesson CreateLesson(
            ClassRoom classRoom, Subject subject, string dayOfWeek,
                TimeSpan startTime, TimeSpan endTime,
                Teacher teacher)
        {
            var lesson = new Lesson(classRoom, subject, dayOfWeek,
                startTime, endTime, teacher, new List<Student>());
            Lessons.Add(lesson);
            return lesson;
        }

        public Teacher CreateTeacher(string name, string lastName)
        {
            var teacher = new Teacher(name, lastName, new List<Lesson>());
            Teachers.Add(teacher);
            return teacher;
        }

        public void AddLessonToTeacher(Lesson lesson, Teacher teacher)
        {
            teacher.AddLesson(lesson);
        }

        public void AddStudentToLesson(Lesson lesson, Student student)
        {
            lesson.Students.Add(student);
        }

        public Student CreateStudent(string firstName, string lastName,
            int year, int group, int indexId)
        {
            var student = new Student(firstName, lastName, year, group, indexId);
            Students.Add(student);
            return student;
        }

        public void RemoveLesson(int id)
        {
            var lesson = Lessons.FirstOrDefault((lesson) => lesson.Id == id);
            if (lesson == null)
            {
                return;
            }

            Lessons.Remove(lesson);
            foreach (var teacher in Teachers)
            {
                teacher.RemoveLesson(lesson.Id);
            }
        }

        public override string ToString()
        {
            return $"School {Name}:";
        }
        public void Display()
        {
            Console.WriteLine($"\t{ToString()}");

            Console.WriteLine("\t\tSchool");
            foreach (var item in Lessons)
            {
                item.Display();
            }

            Console.WriteLine("\t\tSchool Teachers");
            foreach (var item in Teachers)
            {
                item.Display();
            }

            Console.WriteLine("\t\tSchool Subjects");
            foreach (var item in Subjects)
            {
                item.Display();
            }

            Console.WriteLine("\t\tSchool ClassRooms");
            foreach (var item in ClassRooms)
            {
                item.Display();
            }

            Console.WriteLine("\t\tSchool Students");
            foreach (var item in Students)
            {
                item.Display();
            }
        }
    }
}
