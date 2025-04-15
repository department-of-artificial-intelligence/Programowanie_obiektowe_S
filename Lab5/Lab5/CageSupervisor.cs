namespace Lab5.BLL
{
    public class CageSupervisor : Employee
    {
        protected DateTime hireDate;
        protected List<Cage> cagesToSupervise;

        public DateTime HireDate { get; set; }
        public List<Cage> CagesToSupervise => cagesToSupervise;

        public CageSupervisor(string _name, string _surname, DateTime _birthdayDate, DateTime _hiredate, List<Cage> _cagesToSupervise) : base(_name, _surname, _birthdayDate)
        {
            hireDate = _hiredate;
            cagesToSupervise = _cagesToSupervise;
        }
    }
}
