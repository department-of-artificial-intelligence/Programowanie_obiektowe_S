using System.Text;

namespace Kolokwium.BBL
{
    internal class Teacher : Person
    {

        public IList<Lesson> Lessons { get; set; }
        public Teacher(string firstName, string lastName, IList<Lesson> lessons)
        : base(firstName, lastName)
        {

            Lessons = lessons;

        }

        public void AddLesson(Lesson lesson)
        {

            Lessons.Add(lesson);

        }

        public void RemoveLesson(int id)
        {

            Lesson? deleted = Lessons.FirstOrDefault(i => i.Id == id);

            if (deleted != null)
            {

                Lessons.Remove(deleted);

            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Lessons: ");

            foreach (var lesson in Lessons)
            {

                sb.Append(lesson.ToString());

            }

            return $"Teacher | {base.ToString}, {sb.ToString()} ";
        }



    }
}
