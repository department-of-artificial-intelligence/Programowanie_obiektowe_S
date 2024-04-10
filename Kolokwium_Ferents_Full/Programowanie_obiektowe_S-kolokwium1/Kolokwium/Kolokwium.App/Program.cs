namespace Kolokwium.App
{

    class Program
    {

        static void Main(string[] args)
        {

            var students = new List<Student>();
            var teachers = new List<Teacher>();
            School school = new School("XYZ", students, teachers);
            Subject sub1 = school.CreateSubject("Programowanie obiektowe",
            "Przedmiot opisujący programowanie obiektowe w jezyku C#");
            Subject sub2 = school.CreateSubject("Bazy danych",
            "Przedmiot opisujący bazy danych oraz jezyk SQL");
            ClassRoom classRoom1 = school.CreateClassRoom(1, 30, true);
            for (int i = 1; i <= 30; i++) classRoom1.AddSeat(i);
            ClassRoom classRoom2 = school.CreateClassRoom(1, 60, true);
            for (int i = 1; i <= 60; i++) classRoom2.AddSeat(i);
            Teacher teacher1 = school.CreateTeacher("Jan", "Kowalski");
            Teacher teacher2 = school.CreateTeacher("Piotr", "Nowak");
            Lesson lesson1 = school.CreateLesson(classRoom1, sub1, "Wtorek",
            new TimeSpan(12, 0, 0), new TimeSpan(14, 0, 0), teacher1);
            Lesson lesson2 = school.CreateLesson(classRoom2, sub2, "Czwartek",
            new TimeSpan(12, 0, 0), new TimeSpan(14, 0, 0), teacher2);
            teacher1.AddLesson(lesson1);
            teacher2.AddLesson(lesson2);
            Student student1 = school.CreateStudent("Jacek", "Kowal", 5, 1, 123);
            Student student2 = school.CreateStudent("Tomasz", "Nowak", 2, 4, 12123);
            Student student3 = school.CreateStudent("Jerzy", "Bednarski", 5, 1, 35123);
            Student student4 = school.CreateStudent("Maciej", "Kowalski", 5, 1, 78123);
            school.AddStudentToLesson(lesson1, student1);
            school.AddStudentToLesson(lesson1, student2);
            school.AddStudentToLesson(lesson2, student3);
            school.AddStudentToLesson(lesson2, student4);
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            school.Display();
            teacher1.RemoveLesson(lesson1.Id);
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            school.Display();
            Console.ReadKey();



        }





    }




}