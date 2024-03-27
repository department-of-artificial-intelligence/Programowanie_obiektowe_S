namespace Lab05.BBL
{
    public class Zoo
    {
        string Name { get; set; }
        public IList<Employee> Employees { get; set; }
        public IList<Cage> Cages { get; set; }
        public IList<Animal> Animals { get; set; }
        public Zoo(string name, IList<Employee> emps, IList<Cage> cages, IList<Animal> ans)
        {
            Name = name;
            Employees = emps;
            Cages = cages;
            Animals = ans;
        }
    }
}