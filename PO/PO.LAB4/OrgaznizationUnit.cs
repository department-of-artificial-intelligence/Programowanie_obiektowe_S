using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.LAB4
{
    internal class OrgaznizationUnit
    {
        public string Name {  get; set; }
        public string Adress {  get; set; }
        public IList<Lecturer> Lectures { get; set; }
        OrgaznizationUnit(string name, string adress, IList<Lecturer> lectures)
        {

        }
        public override string ToString()
        {
            return "";
        }
    }
}
