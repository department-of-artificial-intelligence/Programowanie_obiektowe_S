namespace Kolokwium.BBL
{
    public class Teacher : Person
    {
        public IList<Lesson> Lessons { get; set; }
        public Teacher(string firstName, string lastName, IList<Lesson> lessons)
            : base(firstName, lastName)
        {
            Lessons = lessons;
        }
        public void AddLesson(Lesson lesson)
        {
            var inBase = FindLesson(lesson.Id);
            if (inBase == null)
            {
                Lessons.Add(lesson);
            }
        }
        public void RemoveLesson(int lessonId)
        {
            var lesson = FindLesson(lessonId);
            if (lesson != null)
            {
                lesson.Teacher = null;
                Lessons.Remove(lesson);
            }
        }
        private Lesson? FindLesson(int lessonId)
        {
            return Lessons?.FirstOrDefault((lesson) => lesson.Id == lessonId);
        }
        public override string ToString()
        {
            return $"Teacher: {base.ToString()}";
        }
    }
}
