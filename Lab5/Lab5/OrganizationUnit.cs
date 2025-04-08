using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class OrganizationUnit
    {
        public string Name {  get; set; }
        public string Address {  get; set; }
        public IList<Lecturer> Lecturers { get; set; }
        public OrganizationUnit(string name, string address, IList<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }

        public override string ToString()
        {
            string temp = $"OrganizationUnit | Name: {Name}, Address: {Address}";
            if(Lecturers != null)
            {
                temp += " , Lecturers: \n";
                foreach(Lecturer lecturer in Lecturers)
                {
                    temp += lecturer + "\n";
                }
            }
            return temp ;  
        }
    }
}
