namespace Lab2
{
	public class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("He~llo World!");

			Person person1 = new Person("Adam", "Miś", new DateTime(1990, 3, 20, 12, 30, 10));
			person1.Details();
			Person person2 = new Student("Michał", "Kot", new DateTime(1990, 4, 13), 3, 5, 12345);
			person2.Details();
			Person person3 = new Player("Robert", "Lewandowski", new DateTime(1988, 10, 3), "Striker", "Bayern", 41);
			person3.Details();

			Student student = new Student("Krzysztof", "Jeż", new DateTime(1990, 12, 29), 2, 5, 54321);
			student.Details();

			((Player)person3).ScoreGoal();
			person3.Details();
			//zad 2
            Console.WriteLine("------------------------");
            ((Student)person2).AddGrade("PO", 5.0D, new DateTime(2011, 2, 20));
            ((Student)person2).AddGrade("Bazy Danych", 5.0D, new DateTime(2011, 2, 13));
            person2.Details();
            Grade grade = new Grade("Bazy Danych", 5.0D, new DateTime(2011, 5, 1));
            student.AddGrade(grade);
            student.AddGrade("AWWW", 5.0D, new DateTime(2011, 5, 11));
            student.AddGrade("AWWW", 4.5D, new DateTime(2011, 4, 2));
            student.Details();
            student.DeleteGrade("AWWW", 4.5D, new DateTime(2011, 4, 2));
            student.Details();
            student.DeleteGrades("AWWW");
            student.Details();
            student.AddGrade("AWWW", 5.0D, new DateTime(2011, 4, 3));
            student.DeleteGrades();
            student.Details();


            Console.WriteLine("------------------------");
            ///zadanie domowe
            Person footballPlayer =
 new FootballPlayer("Mateusz", "Żbik", new DateTime(1986, 8, 10), "striker", "FC Barcelona", 10);
			footballPlayer.Details();
			Person handballPlayer =
 new HandballPlayer("Piotr", "Kos", new DateTime(1984, 9, 14), "striker", "FC Bayern"); //domyślna wartość dla scored goals
			handballPlayer.Details();
            ((Player)handballPlayer).ScoreGoal();
			handballPlayer.Details();
            (footballPlayer as Player).ScoreGoal();
            footballPlayer.Details();
        }
	}

}

/*
 * Z logiki zadania czy można wykminić czy mogą być osoby z nullem (np. bez nazwiska)
 * 
Generic to szablony, to nie jest boxing i unboxing
W C# dziedziczymy tylko po jednej klasie i wielu interfejsów
//Console.WriteLine(this)
Listy mogą być puste, ale mają przydzieloną pamięć
as -> rzutowanie na inny typ referencyjny
//wyszukiwanie wyrażeniami lambda trzeba znać idealnie

Do zad 1
Asocjacja by niszczyć person nie niszczyć carów

ŚWIĘTOŚCIĄ JEST UML, ZAWSZE UML MA PIERWSZEŃSTWO
 */