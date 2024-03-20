using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Person
{
   
    
    public string FirstName
    {
        get; set;
    }
    public string LastName
    {
        get;  set;
    }
    public DateTime DateOfBirth
    {
        get; set;
    }
    public Person(string firstname, string lastname, DateTime dayeOfBirth)
    {
        FirstName = firstname;
        LastName = lastname;
        DateOfBirth = dayeOfBirth;
    }
    public override string ToString()
    {
        return $"FirstName: {FirstName}, LastName: {LastName}, DateOfBirth: {DateOfBirth}";
    }
   
}
class Student : Person
{
    static private int id = 1;


    public IList<FinalGrade> Grades { get; set; }

    public int Semestr { get; set; }

    public int Group
    {
        get; set;
    }
    public int IndexId
    {
        get; set;
    }
    public string Specealization { get; set; }
    public double AverageGrades { get; }
    public Student(string firstname, string lastname, DateTime dateofBirth, string specialization, int semestr= 1,int group): base(firstname, lastname, dateofBirth)
    {
        Semestr = semestr;
        Group = group;
        Specealization = specialization;
    }
    public override string ToString()
    {
        return $"Semestr: {Semestr}, Group: {Group}, Index: {IndexId}, Specealization: {Specealization}";
    }

}
class Lecturer : Person
{
    public string AcademicTitle { get; set; }
    public string Position { get; set; }
    public Lecturer(string academictitle, string position, DateTime dateofBirth ,string firstname, string lastname) : base(firstname, lastname, dateofBirth)
    {
        Position = position;
        AcademicTitle = academictitle;
    }
    public override string ToString()
    {
        return $"AcademicTitle: {AcademicTitle}, Position: {Position}";
    }
}
class OrganizationUnit
{
    public string Name { get; set; }
    public string Adress { get; set; }
    public IList<Lecturer> Lecturers
    {
        get { return Lecturers; }
        set { Lecturers = value; }
    }
    public OrganizationUnit(string name, string adress, IList<Lecturer> lecturers) {
        Name = name;
        Adress = adress;
        Lecturers = lecturers;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Adress: {Adress},Lecturers: {Lecturers}";
    }
}
class FinalGrade
{
    public Subject Subject { get; set; }
    public DateTime Date { get; set; }
    public double Value { get; set; }
    public FinalGrade(Subject subject, double value, DateTime date)
    {
        Subject= subject;
        Value = value;
        Date = date;
    }
    public override string ToString()
    {
        return $"Subject: {Subject},Value {Value}, date: {Date}";
    }

}
class Subject
{
    public int Semestr { get; set; }

    public string Name
    {
        get; set;
    }
    public int HourseCount
    {
        get; set;
    }
    public string Specialization { get; set; }

    public Subject(string name, string specialization, int semestr, int hoursecount)
    {
        Semestr = semestr;
        Name = name;
        Specialization = specialization;
        HourseCount = hoursecount;
    }
    public override string ToString()
    {
        return $"Name: {Name},Semestr : {Semestr},Specialization {Specialization}, HourseCount: {HourseCount}";
    }
}

class Department
{
    public string Name
    {
        get; set;
    }
    public Person Dean { get; set; }
    public IList<OrganizationUnit> OrganizationUnits {  get; set; }
    public IList<Student> Students { get; set; }
    public IList<Subject> Subjects { get; set; }
    Department(Person dean,string name, IList<Subject> subject, IList<Student> student, IList<OrganizationUnit> organizationUnits)
    {
        Name = name;
        Dean = dean;
        Subjects = subject;
        Students = student;
        OrganizationUnits = organizationUnits;
    }
    public override string ToString()
    {
        return $"Name: {Name},Dean : {Dean},Subject: {Subjects},OrganizationUnits : {OrganizationUnits},Student: {Students} ";
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("Jan", "Kowalski", new DateTime(1995, 1, 1), "Informatyka", 1);
        Student student2 = new Student("Piotr", "Nowak", new DateTime(1990, 1, 1), "Matematyka", 3, 2);
        Person student3 = new Student("Adam", "Bedrnarski", new DateTime(1993, 1, 1), "Informatyka", 1, 2);
        Subject subject1 = new Subject("Programowanie obiektowe", "Informatyka", 4, 30);
        Subject subject2 = new Subject("Bazy danych", "Informatyka", 4, 30);
        Subject subject3 = new Subject("Algebra", "Matematyka", 1, 15);
        Subject subject4 = new Subject("Analiza", "Matematyka", 1, 30);
        FinalGrade grade1 = new FinalGrade(subject1, 4.5d, DateTime.Now.AddDays(30));
        FinalGrade grade2 = new FinalGrade(subject1, 5d, DateTime.Now.AddDays(10));
        FinalGrade grade3 = new FinalGrade(subject2, 3.5d, DateTime.Now.AddDays(50));
        FinalGrade grade4 = new FinalGrade(subject2, 3.0d, DateTime.Now.AddDays(20));
        FinalGrade grade5 = new FinalGrade(subject3, 5d, DateTime.Now.AddDays(10));
        FinalGrade grade6 = new FinalGrade(subject3, 4.0d, DateTime.Now.AddDays(10));
        FinalGrade grade7 = new FinalGrade(subject4, 4.0d, DateTime.Now.AddDays(30));
        FinalGrade grade8 = new FinalGrade(subject4, 3.5d, DateTime.Now.AddDays(20));
        Lecturer lecturer1 = new Lecturer("Krzysztof", "Nowakowski", new DateTime(1978, 12, 12), "dr inż.",
        "Adiunkt");
        Lecturer lecturer2 = new Lecturer("Jan", "Kowalski", new DateTime(1960, 10, 12), "Prof. dr hab. inż.",
        "Profesor");
        Lecturer lecturer3 = new Lecturer("Adam", "Nowakowski", new DateTime(1968, 2, 12), "dr inż.", "Adiunkt");
        Lecturer lecturer4 = new Lecturer("Arkadiusz", "Bednarski", new DateTime(1969, 1, 12), "dr hab. inż.",
        "Profesor");
        Lecturer lecturer5 = new Lecturer("Janusz", "Wiśniewski", new DateTime(1988, 2, 12), "dr inż.", "Adiunkt");
        Lecturer lecturer6 = new Lecturer("Dariusz", "Kowalewski", new DateTime(1979, 1, 12), "dr hab. inż.",
        "Profesor");
        var lecturerList1 = new List<Lecturer> { lecturer1, lecturer2 };
        var lecturerList2 = new List<Lecturer> { lecturer4, lecturer3 };
        OrganizationUnit organizationUnit1 = new OrganizationUnit("Katedra Informatyki",
         "Częstochowa", lecturerList1);
        OrganizationUnit organizationUnit2 = new OrganizationUnit("Kadera Inteligentnych Systemów Informatycznych",
         "Częstochowa", lecturerList2);
        Console.WriteLine(organizationUnit1);
        Console.WriteLine(organizationUnit2);
        Lecturer dean = new Lecturer("Tadeusz", "Nowak", new DateTime(1955, 1, 12), "Prof. dr hab. inż.",
         "Profesor");
        Department department = new Department("Wydział Inżynierii Mechanicznej i Informatyki", dean,
        new List<Subject>() { subject1, subject2 },
        new List<Student>() { student1, student2, (Student)student3 });
        Console.WriteLine(department);
    }
}



