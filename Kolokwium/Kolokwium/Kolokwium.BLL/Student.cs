using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    internal class Student : Person
    {
        public int Year { get; }
        public int Group { get; }
        public int IndexId { get; set; }

        public Student(string firstName, string lastName, int year, int group, int indexId) : base(firstName, lastName)
        {
            Year = year;
            Group = group;
            IndexId = indexId;
        }
        public override string ToString()
        {
            return base.ToString() + $"Year: {Year} Group: {Group} Index ID: {IndexId}";
        }
    }
}
