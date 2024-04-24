using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Grade
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public float Value { get; set; }
        public Grade() { }
        public Grade(int id,string className ,float value) {  Id = id; Value = value; ClassName = className; }
    }
}
