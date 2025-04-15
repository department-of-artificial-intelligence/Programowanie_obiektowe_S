


namespace Lab5.BLL
{
    public class Zoo
    {
        protected string _zooName;
        protected List<Employee> _employees;
        protected List<Cage> _cages;
        protected List<Animal> _animals;

        public string? ZooName { get; set; }
        public List<Employee> Employees => _employees;
        public List<Cage> Cages => _cages;
        public List<Animal> Animals => _animals;

        public Zoo(string zooName, List<Employee> employees, List<Cage> cages, List<Animal> animals)
        {
            _zooName = zooName;
            _employees = employees;
            _cages = cages;
            _animals = animals;
        }

        public Cage BuildCage(int capacity, bool isDirty)
        {
            return new Cage(capacity, isDirty);
        }

        public void ExpandCage(Cage cage, int capacity)
        {
            cage.Capacity += capacity;
        }

        public List<Cage> AddRange(List<Cage> cages)
        {
            _cages.AddRange(cages);
            return _cages;
        }

        public List<Employee> AddRange(List<Employee> employees)
        {
            _employees.AddRange(employees);
            return _employees;
        }

        public Employee HireEmployee(string name, string surname, DateTime birthdayDate)
        {
            return new Employee(name, surname, birthdayDate);
        }
    }
}