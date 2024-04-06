using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przygotowanie.BLL
{
    public class Teacher : Person
    {
        public IList<Lesson>Lessons { get; set; }
        public Teacher(string firstName, string lastName, IList<Lesson> lessons)
            :base(firstName, lastName)
        {
            Lessons = lessons;
        }

        public Lesson AddLesson(Lesson lesson)
        {
            Lessons.Add(lesson);
            return lesson;
        } 

        public void RemoveLesson(Lesson lesson)
        {
            Lessons.Remove(lesson);
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += string.Join<Lesson>('\n', Lessons);
            return str;
        }
    }
}
