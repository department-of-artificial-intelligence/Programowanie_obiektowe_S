using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Department
    {
        public string? Name { get; set; }
        public Person? Dean { get; set; }
        public IList<OrganizationUnit>? OrganizationUnits { get; set; }
        public IList<Subject>? Subjects { get; set; }
        public IList<Student>? Students { get; set; }

        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
        }

		public override string ToString()
		{
            string organizationUnits = "";
			if (OrganizationUnits != null)
				foreach (var unit in OrganizationUnits)
					organizationUnits += unit.ToString();

			string subjects = "";
			if (Subjects != null)
				foreach (var subject in Subjects)
					subjects += subject.ToString();

			string students = "";
			if (Students != null)
				foreach (var student in Students)
					students += student.ToString();
			return $"Department name: {Name}\nDean: {Dean}\nOrganization units:\n{organizationUnits}\nStudents:\n{students}\nSubjects:\n{subjects}\n";
		}
	}
}
