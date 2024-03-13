public class Person
{
    protected string _firstName;
    protected string _lastName;
    protected DateTime _DateTime;
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }

    }
    public DateTime DateOfBirth
    {
        get { return _DateTime; }
        set { _DateTime = value; }
    }
    public Person()
    {
        _firstName = "nieznane";
        _lastName = "nieznane";
        _DateTime = DateTime.MinValue;
    }
    public Person(string firstName, string lastName, DateTime dateTime)
    {
        _firstName = firstName;
        _lastName = lastName;
        _DateTime = dateTime;
    }
}