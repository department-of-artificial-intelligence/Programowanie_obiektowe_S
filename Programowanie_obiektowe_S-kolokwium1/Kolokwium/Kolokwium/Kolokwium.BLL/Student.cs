using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium.BLL
{
    public class Student : Person
    {
        public int Year { get; set; }
        public int Group { get; set; }
        public int IndexID {  get; set; }
        public Student(string FName, string LName, int year, int group, int indexID) : base(FName, LName)
        {
            Year = year;
            Group = group;
            IndexID = indexID;
        }
        public override string ToString()
        {
            return $"Student: {base.ToString()} | Year: {Year} | Group: {Group} | id: {IndexID}";
        }
    }
}