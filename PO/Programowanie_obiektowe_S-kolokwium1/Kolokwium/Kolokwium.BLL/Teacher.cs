using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    class Teacher: Person
    {
        public IList<Lesson> Lessons { get; set; }
        public Teacher(string firstname,  string lastname, IList<Lesson> lessons): base(firstname, lastname)
        {
            Lessons = lessons;
        }
        public void RemoveLesson(int id)
        {
            Lessons.Remove(i => i.Id == id);
        }
        public override string ToString()
        {
            string res=  base.ToString()+"Lessons:\n";
            foreach (var lesson in Lessons)
            {
                res+= "\t"+lesson+"\n";
            }
            return res;
        }
    }
}
