namespace PO.Lab04
{
    internal class Department
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
            Subjects = new List<Subject>(subjects);
            Students = new List<Student>(students);
        }


        public override string ToString()
        {
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
                $"\nOrganization Units: {substr}" +
                $"\nStudents: {studstr}";
        }
    }
}
