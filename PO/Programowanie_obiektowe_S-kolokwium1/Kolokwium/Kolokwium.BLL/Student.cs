using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    class Student : Person
    {
        public int Year { get; }
        public int Group { get;  }
        public int IndexId { get; }
        public Student(string firstname, string lastname, int year, int group, int indexId): base(firstname, lastname)
        {
            Year = year;
            Group = group;
            IndexId = indexId;
        }
        public override string ToString()
        {
            return base.ToString()+ $"Year: {Year}, Group: {Group}, IndexId: {IndexId}";
        }
    }
}
