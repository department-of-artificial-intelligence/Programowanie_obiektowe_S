
namespace Lab2
{
    public class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public Person()
        {

            _firstName = "Brak";
            _lastName = "BRAK NAZWISKA";
            _dateOfBirth = DateTime.Now;

        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName=firstName;
            _lastName=lastName; 
            _dateOfBirth=dateOfBirth;

        }

        public string FirstName { 
            
            
            get { return _firstName; } 
            set { _firstName = value; }

        
        }
        public  string LastName { 
            
            get { return _lastName; }
            set { _lastName = value; }

            
        }
        public DateTime DateOfBirth { 
            get { return _dateOfBirth; } 
            set { _dateOfBirth = value; } 
        }

        public override string ToString()
        {
            return $"Person | Imie: {_firstName}, Nazwisko: {_lastName}, Data_urodzenia {_dateOfBirth}";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);

        }
    

   


    }
}
