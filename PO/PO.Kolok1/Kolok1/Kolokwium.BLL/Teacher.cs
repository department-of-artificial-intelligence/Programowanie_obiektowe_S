using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    internal class Teacher : Person
    {
        public IList<Lesson> Lessons { get; set; }

        public Teacher(string firstName, string lastName, IList<Lesson> lessons) : base(firstName, lastName)
        {
            Lessons = lessons;
        }
        public Lesson? AddLesson(Lesson lesson)
        {
            Lessons.Add(lesson);
            return null;
        }

        public void RemoveLesson(int id)
        {
            Lessons.Remove(id);
        }

        public override string ToString()
        {
            string s = new string(base.ToString + $"Lessons: \n");
            foreach (var item in Lessons)
            {
                s += item.ToString();
            }
            return s;
        }
    }
}
