using System.Reflection;

namespace Lab2.Bll
{
    public class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

        public Person() {
            _firstName = "";
            _lastName = "";
            _dateOfBirth = DateTime.Now;
        }
        public Person(string firstname, string lastname, DateTime dateOfBirth) {
            _firstName=firstname;
            _lastName = lastname;
            _dateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"Imie: {_firstName}, Nazwisko: {_lastName}, Data urodzenia: {_dateOfBirth}";
        }
        public virtual void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
