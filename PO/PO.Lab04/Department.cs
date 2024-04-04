namespace PO.Lab04
{
    internal class Department : IContainer, IDisplayable
    {

        public string Name { set; get; }
        public Person Dean { set; get; }
        public IList<OrganizationUnit> OrganizationUnits { set; get; }
        public IList<Subject> Subjects { set; get; }
        public IList<Student> Students { set; get; }

        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            OrganizationUnits = new List<OrganizationUnit>();
            Subjects = subjects;
            Students = students;
        }


        public override string ToString()
        {
            string orgstr = "";
            foreach (var org in OrganizationUnits)
            {
                orgstr += "\n   " + org.ToString();
            }

            string substr = "";
            foreach (var sub in Subjects)
            {
                substr += "\n   " + sub.ToString();
            }

            string studstr = "";
            foreach (var stud in Students)
            {
                studstr += "\n   " + stud.ToString();
            }


            return $"Departament | Name: {Name}, " +
                $"\nDean: {Dean}, " +
                $"\nOrganization Units: {orgstr}" +
                $"\nSubjects: {substr}" +
                $"\nStudents: {studstr}";
        }
    }
}
