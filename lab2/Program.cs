namespace lab2
{
    internal class Program
    {
        class Person
        {
            protected string _firstName;
            protected string _lastName;
            protected DateTime _dateOfBirth;

            public string FirstName { get => _firstName; set => _firstName = value; }
            
            public string LastName { get => _lastName; set => _lastName = value; }
            
            public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }

            public Person()
            {
                _firstName = "Nieznane";
                _lastName = "Nieznae";
                _dateOfBirth = DateTime.Now;
            }

            public Person(string firstName, string lastName, DateTime dateOfBirth)
            {
                _firstName = firstName;
                _lastName = lastName;
                _dateOfBirth = dateOfBirth;
            }

            public virtual void Details()
            {

            }



        }

        class Student
        {
            private int _year;
            private int _group;
            private int _indexId;

            public int Year { get => _year; set => _year = value; }
            public int Group { get => _group; set => _group = value; }
            public int IndexId { get => _indexId; set => _indexId = value; }

            public Student() : basic()
            {

            }
            
            public Student (int year, int group, int indexId) : basic()
            {
                _year = year;
                _group = group;
                _indexId = indexId;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
