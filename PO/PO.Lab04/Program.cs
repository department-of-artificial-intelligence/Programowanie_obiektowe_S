using PO.Lab04;


Console.WriteLine("------   Zadanie 1   ------");
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
Lecturer lecturer1 = new Lecturer("Krzysztof", "Nowakowski", new DateTime(1978, 12, 12), "dr inż.", "Adiunkt");
Lecturer lecturer2 = new Lecturer("Jan", "Kowalski", new DateTime(1960, 10, 12), "Prof. dr hab. inż.", "Profesor");
Lecturer lecturer3 = new Lecturer("Adam", "Nowakowski", new DateTime(1968, 2, 12), "dr inż.", "Adiunkt");
Lecturer lecturer4 = new Lecturer("Arkadiusz", "Bednarski", new DateTime(1969, 1, 12), "dr hab. inż.", "Profesor");
Lecturer lecturer5 = new Lecturer("Janusz", "Wiśniewski", new DateTime(1988, 2, 12), "dr inż.", "Adiunkt");
Lecturer lecturer6 = new Lecturer("Dariusz", "Kowalewski", new DateTime(1979, 1, 12), "dr hab. inż.", "Profesor");
var lecturerList1 = new List<Lecturer> { lecturer1, lecturer2 };
var lecturerList2 = new List<Lecturer> { lecturer4, lecturer3 };
OrganizationUnit organizationUnit1 = new OrganizationUnit("Katedra Informatyki", "Częstochowa", lecturerList1);
OrganizationUnit organizationUnit2 = new OrganizationUnit("Kadera Inteligentnych Systemów Informatycznych", "Częstochowa", lecturerList2);

Console.WriteLine("-- Organization Unit 1 --");
Console.WriteLine(organizationUnit1);

Console.WriteLine("-- Organization Unit 2 --");
Console.WriteLine(organizationUnit2);
Lecturer dean = new Lecturer("Tadeusz", "Nowak", new DateTime(1955, 1, 12), "Prof. dr hab. inż.", "Profesor");
Department department = new Department("Wydział Inżynierii Mechanicznej i Informatyki", dean,
    new List<Subject>() { subject1, subject2 },
    new List<Student>() { student1, student2, (Student)student3 });

Console.WriteLine("-- Department --");
Console.WriteLine(department);


Console.WriteLine("------   Zadanie 2   ------");
student1.Add(grade1);
student2.AddRange(new List<FinalGrade> { grade2, grade3 });
((Student)student3).AddRange(new List<FinalGrade> { grade4 });
Department department2 = new Department("WE",
    new Lecturer("Jan", "Nowak", DateTime.Now.AddYears(-56), "dr hab.", "dziekan"),
    new List<Subject>() { subject3, subject4 },
    new List<Student>() { student1, student2, (Student)student3 });

department2.AddRange(new List<OrganizationUnit> {
    new OrganizationUnit("IOO", "Rolnicza 2", new List<Lecturer>{lecturer5}),
    new OrganizationUnit("SKL", "Miedziana 13", new List<Lecturer>{lecturer6}) });

department2.Add(new Student("Jacek", "Bednarski", new DateTime(1989, 2, 12), "Matematyka", 1).AddRange(
    new List<FinalGrade> { grade7, grade8 }) as Student);

department2.Add(new Student("Marek", "Wiśniewski", new DateTime(2001, 12, 1), "Matematyka", 1).AddRange(
    new List<FinalGrade> { grade5, grade6 }) as Student);
Console.WriteLine("Print Departament");
department2.Print();

Console.WriteLine("Print Student");
var obtainedStudent = department2.Get<Student>(x => x.Group == 1);
obtainedStudent.Print();

Console.WriteLine("Print Student");
department2.Get<Student>().GetList<FinalGrade>(g => g.Subject.Name == "Informatyka").Print();

Console.WriteLine("Print Unit");
department2.Add(new Subject("Paradygmaty programowania", "Informatyka", 2, 10));
department2.Add(new Subject("Podstawy sieci komputerowych", "Informatyka", 2, 30));
var organizationUnit = department2.Get<OrganizationUnit>(x => x.Name == "SKL");
organizationUnit.Print();

department2.Get<OrganizationUnit>(x => x.Name == "SKL")
.Add(new Lecturer("Maria", "Nowak", new DateTime(1912, 12, 1), "mgr", "Lektor"));
organizationUnit.Print();
department2.Get<OrganizationUnit>(x => x.Name == "SKL")
    .Remove<Lecturer>(l => l.FirstName == "Maria");
department2.GetList<OrganizationUnit>(ou => ou.Name == "SKL").Print();
/*
*/