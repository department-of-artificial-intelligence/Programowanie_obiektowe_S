namespace Lab5.BLL
{
    public class Employee
    {
        protected string name;
        protected string surname;
        protected DateTime birthdayDate;

        public string? Name { get; set; }
        public string? Surame { get; set; }
        public DateTime BirthdayDate { get; set; }

        public Employee(string _name, string _surname, DateTime _birthdayDate)
        {
            name = _name;
            surname = _surname;
            birthdayDate = _birthdayDate;
        }
    }
}