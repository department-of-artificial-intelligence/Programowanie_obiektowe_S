
using System.Collections.Generic;
using System;
public class DisplayActionExtensions
{
    public static void Print(TObjectType obj)
    {

    }

    public static void Print(IList <TObjectType> list)
    {

    }
}

interface IDisplayable 
{
}

public class CrudActionExtensions
{
    public static IList<TObjectType> Set(IContainer containerObject);
    public static void ForEach(IList<TObjectType> list, Action<TObjectType> action);
    public static TObjectType Get(IContainer container, searchPredicate Func<TObjectType, bool>);
    public static IContainer Add(IContainer container, TObjectType obj);
    public static bool Remove(IContainer container, Func<TObjectType,bool>);
}

interface IContainer
{

}
public class Program
{
    public static void Main()
    {
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
    }
}