using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Po.Lab3
{
    public class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime? _birthDate;

        public string FirstName
        {
            get => _firstName; set =>
                _firstName = value;
        }
        public string LastName
        {
            get => _lastName; set =>
                _lastName = value;
        }
        public DateTime BirthDate
        {
            get => (DateTime)_birthDate; set =>
                _birthDate = value;
        }
        public Person()
        {
            _firstName = null;
            _lastName = null;
            _birthDate = null;
        }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }
        public override string ToString()
        {
            return $"First Name: {_firstName}, " +
                $"Last Name: {_lastName}, Birth Date: {_birthDate}";
        }
        public virtual void Details()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
       
    
