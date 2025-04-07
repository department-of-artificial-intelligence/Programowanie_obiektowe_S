using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class OrganizationUnit : IDisplayable, IContainer
    {
        public string Name {  get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; }
        public OrganizationUnit(string name ,string address,IList<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }
        public override string ToString()
        {
            string lek = "";
            foreach (var l in Lecturers)
            {

                lek += l.ToString();

            }
            return $" OrganizationUnit Nazwa: {Name} Adres: {Address} "+lek+"\n";
        }

    }
}
