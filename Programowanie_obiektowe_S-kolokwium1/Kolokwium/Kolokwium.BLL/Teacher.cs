using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Teacher : Person 
    {
        public IList<Lesson> Lessons;

        public Teacher(string firstName, string lastName, IList<Lesson> lessons)
            : base (firstName, lastName)
        {
            Lessons = lessons;
        }

        public Lesson AddLesson(Lesson lesson)
        {
            Lessons.Add(lesson);
            return lesson;
        }
        public void RemoveLesson(int id)
        {
            foreach (Lesson lesson in Lessons)
            {
                if (Lessonsd)
            }
        }

        public override string ToString()
        {
            string lessonstr = "";
            foreach (Lesson lesson in Lessons)
            {
                lessonstr += lesson.ToString();
            }
            return $"{base.ToString()} {lessonstr}";
        }
    }
}
