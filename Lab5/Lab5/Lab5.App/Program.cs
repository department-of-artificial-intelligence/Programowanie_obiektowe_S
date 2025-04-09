// See https://aka.ms/new-console-template for more information
using Lab5.BLL;

Console.WriteLine("Hello, World!");
Animal dog = new Mammal("flesh", 4, "Europe", "Gray Wolf", "Europe");
Animal cow = new Mammal("grass", 4, "Europe", "B. taurus", "Europe");
Animal crocodile1 = new Reptile("flesh", 4, "Africa", "C. niloticus", false);
Animal cobra = new Reptile("flesh", 0, "Africa", "Serpentes", true);
Animal falcon = new Bird("flesh", 2, "Europe", "Falconidae", 1.2, 125);
