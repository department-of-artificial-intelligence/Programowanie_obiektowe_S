using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Journal : Item
    {
        public int Number { get; set; }

        public Journal() : base() { }

        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
        {
            Title = title;
            Id = id;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
            Number = number;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string GenerateBarCode()
        {
            Random random = new Random();
            char[] dostepneZnaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=<>?".ToCharArray();
            char[] wynik = new char[9];

            for (int i = 0; i < 9; ++i)
            {
                wynik[i] = dostepneZnaki[random.Next(dostepneZnaki.Length)];
            }

            string wynikString = new string(wynik);
            Console.WriteLine(wynikString);
        }
    }
}
