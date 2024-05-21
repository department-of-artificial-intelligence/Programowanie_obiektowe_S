using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab09.BLL
{
    public class StudentModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IndexNumber { get; set; }
        public string Faculty { get; set; }
        public string GetGrades { get; set; }
    }
}
