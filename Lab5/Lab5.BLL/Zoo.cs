using Generic.Extensions;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo:IContainer,IDisplayable
    {
        private string? _name;
        private IList<Employee>? _employee;
        private System.Collections.Generic.IList<Cage>? _cage;
        private System.Collections.Generic.IList<Animal>? _animal;

        public string Name
        {
            get { return _name!; }
            set
            {
                _name = value;
            }
        }

        public IList<Employee> Employees
        {
            get { return _employee!; }
            set
            {
                _employee = value;
            }
        }

        public IList<Cage> Cages
        {
            get { return _cage!; }
            set
            {
                _cage = value;
            }
        }

        public IList<Animal> Animals
        {
            get { return _animal!; }
            set
            {
                _animal = value;
            }
        }

        public Zoo(string name, List<Employee> employee, List<Cage> cage, List<Animal> animal)
        {
            Name = name;
            Employees = employee ?? new List<Employee>();
            Cages = cage ?? new List<Cage>();
            Animals = animal ?? new List<Animal>();

        }

        public IContainer AddRange(List<Cage> list)
        {
            foreach (var cage in list)
            {
                Cages.Add(cage);
            }
            return this;
        }

        public IContainer AddRange(List<Employee> list)
        {
            foreach (var employee in list)
            {
                Employees.Add(employee);
            }
            return this;
        }
        public Cage BuildCage(int size, bool isCleaningNeeded)
        {
            var cage = new Cage(size, isCleaningNeeded, new List<Animal>());
            Cages.Add(cage);
            return cage;
        }

        public void ExpandCage(Cage cage, int size)
        {
            cage.Size += size;
        }

        public Employee HireEmployee(string firstName, string lastName, System.DateTime dateOfBirth)
        {
           
            var supervisor = new CageSupervisor(firstName, lastName, dateOfBirth, DateTime.Now, new List<Cage>());
            _employee!.Add(supervisor);
            return supervisor;
        }

        public Employee HireEmployee(Employee employee)
        {
            _employee!.Add(employee);
            return _employee.Last();
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Zoo: {Name}");
            sb.AppendLine("=== CAGES ===");
            foreach (var cage in Cages)
            {
                sb.AppendLine(cage.ToString());
                foreach (var animal in cage.Animals)
                {
                    sb.AppendLine($"  - {animal.Species} ({animal.GetType().Name}) | Origin: {animal.Origin}, Food: {animal.FoodType}");
                    if (animal is Bird bird)
                    {
                        sb.AppendLine($"    Fly distance: {bird.Fly()}");
                    }
                    if (animal is Mammal mammal)
                    {
                        sb.AppendLine($"    Environment: {mammal.Environment}");
                    }
                    if (animal is Reptile reptile)
                    {
                        sb.AppendLine($"    Is venomous: {(reptile.IsVenomous ? "Yes" : "No")}");
                    }
                }
            }

            sb.AppendLine("=== EMPLOYEES ===");
            foreach (var emp in Employees)
            {
                sb.AppendLine(emp.ToString());
            }

            return sb.ToString();
        }

        
    }
}