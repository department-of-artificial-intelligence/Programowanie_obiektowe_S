namespace Lab5.BLL
{
    public class Zoo
    {
        public string Name { get; set; }
        public IList<Employee> Employees { get; set; }
        public IList<Cage> Cages { get; set; }
        public IList<Animal> Animals { get; set; }

        public Zoo(string name, IList<Employee> employees, IList<Cage> cages, IList<Animal> animals)
        {
            Name = name;
            Employees = employees;
            Cages = cages;
            Animals = animals;
        }

        public override string ToString()
        {
            string s1 = string.Join(", ", Employees);
            string s2 = string.Join(", ", Cages);
            string s3 = string.Join(", ", Animals);
            return $"Name: {Name}, \n {Employees} \n {Cages} \n {Animals}";
        }
    }
}