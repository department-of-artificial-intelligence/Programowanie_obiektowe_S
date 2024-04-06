using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przygotowanie.BLL
{
    public class Student : Person
    {
        public int Year { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }

        public Student(string firstName, string lastName, int year, int group, int indexId)
            :base(firstName, lastName)
        {
            Year = year;
            Group = group;
            IndexId = indexId;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"Year: {Year}, group: {Group}, index: {IndexId}";
            return str;
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
