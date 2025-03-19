using System;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello test");
            Item item1 = new Journal("JAISCR", 1, "Springer", new DateTime(2000, 1, 1), 1);
            item1.Details();
            Console.WriteLine(item1.GenerateBarCode()); //test generate






            Console.ReadKey();
        }
    }
}

// abstrakcyjne klasy w c++ muszą mieć metody abstrakcyjne, w c# tak nie jest
// implementacja za pomocą lambdy ( => ) to funkcja jest returnem
// override
// przeciążanie (ten sam typ, inne argumenty/parametry)
// przesłanianie (operator new, jak unsafe) prawie nigdy nie używane
// Każdy interfejs zaczyna się na I, jak się da niech kończy się na able
// Klasy abstrakcyjne zapisane kursywą na diagramie UML

//GenerateBarCode ma wygenerować 9 liczb dla booka, dla journala 8 znaków
// items:Ilist<Item> <- agregacja

//W IItemManagement metoda ostatnia to metoda przyjmująca predykat lambda, ważna
//Expression tree bardzo ważny temat z wykładu