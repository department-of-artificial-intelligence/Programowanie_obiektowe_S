using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium.BLL
{
    public class Teacher : Person
    {
        public IList<Lesson> Lessons { get; set; }

        public Teacher(string FName, string LName, IList<Lesson> lessons) : base(FName, LName)
        {
            Lessons = lessons;
        }
        public Lesson AddLesson(Lesson les)
        {
            Lessons.Add(les);
            return les;
        }
        public void RemoveLesson(int id)
        {
            try
            {
                Lessons.Remove(Lessons.FirstOrDefault(c => c.Id == id));
            }
            catch
            {
                Console.WriteLine("NULL REF removelesson COUGHT!!");
            }

        }
        public override string ToString()
        {
            string str = $"Teacher: {Name} | {LastName}";
            if(Lessons.Count > 0)
            {
                str += Lessons.ToString() + "\n";
            }
            return str;
        }
    }
}