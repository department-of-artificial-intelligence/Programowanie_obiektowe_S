class Student
{
    private int id;
    public IList<FinalGrade> Grades { get; set; }
    public int Semester { get; set; }
    public int Group { get; set; }
    public int IndexId { get; set; }
    public string Specialization { get; set; }
    public double AverageGrades { get; }
    public string Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester)
    {
        
    }
    public override string ToString()
    {
        return $"{id}{Grades}{Semester}{Group}{IndexId}{Specialization}{AverageGrades}";
    }
}

class Department
{
    public string Name { get; set; }
    public Person Dean { get; set; }
    IList<OrganizationUnit> OrganizationUnits { get; set; }
    IList<Subject> Subjects { get; set; }
    IList<Student> Students { get; set; }
    public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students);
    public override string ToString() 
    {
        return $"{Name}{Dean}";
    }
}

class Subject
{
    public string Name { get; set; }
    public string Specialization { get; set; }
    public int Semester { get; set;}
    public int HoursCount { get; set; }
    public Subject(string name, string specialization, int semester, int hoursCount);
    public override string ToString()
    {
        return $"{Name}{Specialization}{Semester}{HoursCount}";
    }
}

class FinalGrade
{
    public Subject Subject { get; set; }
    public DateTime Date { get; set; }
    public double Value { get; set; }
    public FinalGrade(Subject subject, double value, DateTime date);
    public override string ToString() 
    {
        return $"{Subject}{Date}{Value}";
    }
}

class OrganizationUnit
{
    public string Name { get; set; }
    public string Address { get; set; }
    public IList<Lecturer> Lecturers { get; set; }
    public OrganizationUnit(string name, string address, IList<Lecturer>);
    public override string ToString() 
    {
        return $"{Name}{Address}{Lecturers}";
    }
}

class Lecturer
{
    public string AcademicTitle { get; set; }
    public string Position { get; set; }
    public Lecturer(string firstName, string lastName, DateTime dateOfBirth, string academicTitle, string position);
    public override string ToString()
    {
        return $"{AcademicTitle}{Position}";
    }
}

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Person(string FirstName, string LastName, DateTime dateOfBirth);
    public override string ToString()
    { 
    }
}

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