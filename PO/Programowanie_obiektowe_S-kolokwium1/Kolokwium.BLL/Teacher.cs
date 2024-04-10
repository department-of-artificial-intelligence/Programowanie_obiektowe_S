using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Teacher : Person
    {
        public IList<Lesson> Lessons { get; set; }

        public Teacher(string firstName, string lastName,IList<Lesson> lessons):base(firstName, lastName)
        {
            Lessons = lessons;
        }
        public Lesson AddLesson(Lesson lesson) { Lessons.Add(lesson); return lesson; }
        public void RemoveLesson(int id) { Lessons.Remove(Lessons.First(o => o.Id == id)); }
        public override string ToString()
        {
            var result = $"Teacher {base.ToString()}\nLessons of teacher:\n";
            foreach (Lesson lesson in Lessons) {  result += lesson.ToString()+'\n'; }
            return result;
        }

    }
}
