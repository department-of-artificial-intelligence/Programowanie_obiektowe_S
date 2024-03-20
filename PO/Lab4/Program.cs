using System.Runtime.CompilerServices;

namespace Lab4
{
    //zad1
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Person(string firstName,string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
    
    public class Lecturer : Person
    {
        public string AcademicTitle { get; set; }
        public string Positon { get; set; }
        public Lecturer(string firstName, string lastName, DateTime dateOfBirth,string academicTitle, string positon):base(firstName,lastName,dateOfBirth)
        {
            AcademicTitle = academicTitle;
            Positon = positon;
        }
        public override string ToString()
        {
            return $"{AcademicTitle} {base.ToString()}";
        }
    }
    
    public class Student : Person, IContainer
    {
        private static int _id;

        public List<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int indexId { get { return _id; } set { _id = value; } }
        public string Specialization { get; set; }
        public double AverageGrades { get {
                var sum = 0d;
                foreach (var g in Grades) sum += g.Value;
                return sum/Grades.Count;} }
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester=1): base(firstName, lastName, dateOfBirth)
        {
            Semester = semester;
            Group = group;
            Specialization = specialization;
            Grades = new List<FinalGrade>();
        }
        public override string ToString()
        {
            return $"{base.ToString()}, grupa {Group}";
        }
    }
    
    public class Subject
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Semester { get; set; }
        public int HoursCount { get; set; }
        public Subject(string name, string specialization, int semester, int hoursCount)
        {
            Name = name;
            Specialization = specialization;
            Semester = semester;
            HoursCount = hoursCount;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    
    public class FinalGrade
    {
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public FinalGrade(Subject subject, double value, DateTime date)
        {
            Subject = subject;
            Date = date;
            Value = value;
        }
        public override string ToString()
        {
            return $"{Subject}: {Value}";
        }
    }
    
    public class OrganizationUnit: IContainer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Lecturer> Lecturers { get; set; }
        public OrganizationUnit(string name, string address, List<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }
        public override string ToString()
        {
            string result = $"{Name}, adres: {Address}\nLecturers:\n";
            foreach (var le in Lecturers) { result+= le.ToString() + '\n' ; }
            return result+'\n';
        }
    }

    public class Department: IContainer
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public List<OrganizationUnit> OrganizationUnits { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }
        public Department(string name, Person dean, List<Subject> subjects, List<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
            OrganizationUnits = new List<OrganizationUnit>();
        }
        public override string ToString()
        {
            var result = $"{Name}, dean:{Dean}\nOrganization units:\n";
            foreach (var ou in OrganizationUnits) { result+= ou.ToString()+'\n' ;}
            result+= "\nSubjects:\n" ;
            foreach (var le in Subjects) {  result+= le.ToString() + '\n'; }
            result += "\nStudents:\n";
            foreach (var le in Students) { result += le.ToString()+ '\n'; }
            return result;
        }
    }
    //zad2

    public interface IContainer { }
    public interface IDisplayable{ }

    public static class DisplayActionExtensions
    {
        public static void Print<TObjectType>(this TObjectType obj)
        {
            Console.WriteLine(obj.ToString());
        }
        public static void Print<TObjectType>(this List<TObjectType> obj)
        {
            foreach (var ob in obj) { Print(ob); }
        }
    }

    public static class CrudActionExtensions
    {
        public static IList<TObjectType> Set<TObjectType>(this IContainer containerObject)
        {
            var containerObjectType = containerObject.GetType();
            var propertyInfo = containerObjectType.GetProperties()
            .FirstOrDefault(p => p.PropertyType ==
            typeof(IList<TObjectType>));
            var value = propertyInfo?.GetValue(containerObject);
            return value as IList<TObjectType>;
        }
        public static void ForEach<TObjectType>(this List<TObjectType> list, Action<TObjectType> action)
        {
            foreach (var item in list) { action(item); }
        }

        public static TObjectType Get<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var list = container.Set<TObjectType>();
            TObjectType res = default(TObjectType);
            foreach (var item in list) { if  (searchPredicate(item)) {  res = item; break; } }
            return res;
        }
        public static TObjectType Get<TObjectType>(this IContainer container)
        {
            var list = container.Set<TObjectType>();
            TObjectType res = default(TObjectType);
            foreach (var item in list) { if (true) { res = item; break; } }
            return res;
        }

        public static List<TObjectType> GetList<TObjectType>(this IContainer container, Func<TObjectType, bool> searchPredicate)
        {
            var list = container.Set<TObjectType>();
            List<TObjectType> res = new List<TObjectType> { };
            foreach (var item in list) { if (searchPredicate(item)) { res.Add(item); break; } }
            return res;
        }
        public static IContainer Add<TObjectType>(this IContainer container, TObjectType obj)
        {
            container.Set<TObjectType>()?.Add(obj);
            return container;
        }
        public static bool Remove<TObjectType>(this IContainer container, Func<TObjectType, bool> searchFn)
        {
            bool result = false;
            var list = container.Set<TObjectType>();
            foreach (TObjectType objectType in  list) { if (searchFn(objectType)) list.Remove(objectType);result = true; }
            return result;
        }
        public static IContainer AddRange<TObjectType>(this IContainer container, List<TObjectType> listOfElements)
        {
            var list = container.Set<TObjectType>();
            foreach (var item in listOfElements) { list.Add(item); }
            return container;
        } 
    }

    public class Program
    {
        public static int Main(string[] args)
        {
            //zad1
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

            //zad2
            student1.Add(grade1);
            student2.AddRange(new List<FinalGrade> { grade2, grade3 });
            ((Student)student3).AddRange(new List<FinalGrade> { grade4 });
            Department department2 = new Department("WE",
            new Lecturer("Jan", "Nowak", DateTime.Now.AddYears(-56), "dr hab.", "dziekan"),
            new List<Subject>() { subject3, subject4 },
            new List<Student>() { student1, student2, (Student)student3 }
            );
            department2.AddRange(new List<OrganizationUnit>
{
new OrganizationUnit("IOO", "Rolnicza 2", new List<Lecturer>{lecturer5}),
new OrganizationUnit("SKL", "Miedziana 13", new List<Lecturer>{lecturer6})
});
            department2.Add(new Student("Jacek", "Bednarski", new DateTime(1989, 2, 12), "Matematyka", 1)
            .AddRange(new List<FinalGrade> { grade7, grade8 }) as Student);
            department2.Add(new Student("Marek", "Wiśniewski", new DateTime(2001, 12, 1), "Matematyka", 1)
            .AddRange(new List<FinalGrade> { grade5, grade6 }) as Student);
            department2.Print();
            var obtainedStudent = department2.Get<Student>(x => x.Group == 1);
            obtainedStudent.Print();
            department2.Get<Student>()
            .GetList<FinalGrade>(g => g.Subject.Name == "Informatyka")
            .Print();
            department2.Add(new Subject("Paradygmaty programowania", "Informatyka", 2, 10));
            department2.Add(new Subject("Podstawy sieci komputerowych", "Informatyka", 2, 30));
            var organizationUnit = department2.Get<OrganizationUnit>(x => x.Name == "SKL");
            organizationUnit.Print();
            department2.Get<OrganizationUnit>(x => x.Name == "SKL")
            .Add(new Lecturer("Maria", "Nowak", new DateTime(1912, 12, 1), "mgr", "Lektor"));
            organizationUnit.Print();
            department2.Get<OrganizationUnit>(x => x.Name == "SKL")
            .Remove<Lecturer>(l => l.FirstName == "Maria");
            department2.GetList<OrganizationUnit>(ou => ou.Name == "SKL")
            .Print();

            return 0;
        }
    }
}
    