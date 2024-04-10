namespace Lab5.BLL
{
    public class Zoo
    {

        string Name { get; set; }
        public IList<Employee> employees { get; set; }
        public IList<Cage> cages { get; set; }
        public IList<Animal> animals { get; set; }




        public Employee Employee
        {
            get => default;
            set
            {
            }
        }
    }
}