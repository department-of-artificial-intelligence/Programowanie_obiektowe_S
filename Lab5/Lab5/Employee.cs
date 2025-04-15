namespace Lab5.BLL
{
    public class Employee
    {
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime BirthdayDate { get; set; }

		public Employee(string _name, string _surname, DateTime _birthdayDate)
        {
            Name = _name;
            Surname = _surname;
            BirthdayDate = _birthdayDate;
        }

		public override string ToString()
		{
			return $"Name: {Name}\nSurname: {Surname}\nDate of birthday:{BirthdayDate.ToString("dd.MM.yyyy")}\n";
		}

        public void Print() 
        {
            Console.WriteLine(ToString());
        }
	}
}