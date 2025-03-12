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



			///zadanie domowe
			Person footballPlayer =
 new FootballPlayer("Mateusz", "Żbik", new DateTime(1986, 8, 10), "striker", "FC Barcelona", 10);
			footballPlayer.Details();
			Person handballPlayer =
 new HandballPlayer("Piotr", "Kos", new DateTime(1984, 9, 14), "striker", "FC Bayern"); //domyślna wartość dla scored goals
			handballPlayer.Details();

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