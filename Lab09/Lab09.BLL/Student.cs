using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab09.BLL
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IndexNumber { get; set; }
        public string Faculty { get; set; }
        [JsonIgnore]
        [XmlIgnore]
        [SerializationIgnore]
        public IList<Grade> Grades { get; set; }
        [JsonIgnore]
        [XmlIgnore]
        [SerializationIgnore]
        public string GetGrades { get {
                string res = "";    
                for (int i = 0; i < Grades.Count-1; i++)
                {
                    res += Grades[i].Value+" ";
                }
                res += Grades[Grades.Count - 1].Value;
                return res;
            }
        }
        public Student() { 
            Name = string.Empty;
            Surname = string.Empty;
            IndexNumber = 0;
            Faculty = string.Empty;
            Grades = new List<Grade>();
        }
        public Student(string name, string surname, int indexNumber, string faculty)
        {
            Name = name;
            Surname = surname;
            IndexNumber = indexNumber;
            Faculty = faculty;
            Grades = new List<Grade>();
        }
    }
}
