namespace Lab5.BLL
{
    public class Zoo
    {
        private string _name;
        private List<Employee> _employee;
        private System.Collections.Generic.List<Cage> _cage;
        private System.Collections.Generic.List<Animal> _animal;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public List<Employee> Employees
        {
            get { return _employee; }
            set
            {
                _employee = value;
            }
        }

        public List<Cage> Cages
        {
            get { return _cage; }
            set
            {
                _cage = value;
            }
        }

        public System.Collections.Generic.List<Animal> Animals
        {
            get { return _animal; }
            set
            {
                _animal = value;
            }
        }

        public Zoo(string name, List<Employee> employee, List<Cage> cage, List<Animal> animal)
        {
            Name = name;
            Employees = employee;
            Cages = cage;
            Animals = animal;

        }

        public Cage BuildCage(int size, bool isCleaningNeeded)
        {
            Cage temp = new Cage(size, isCleaningNeeded, null);
            Cages.Add(temp);
            return temp;
        }

        public void ExpandCage(Cage cage, int size)
        {
            cage.Size += size;
        }
    }
}