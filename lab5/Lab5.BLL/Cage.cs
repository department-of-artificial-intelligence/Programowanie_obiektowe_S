using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private int _number;
        public int Number {get { return _number;}set { Random rand = new Random();  _number = rand.Next(1,100); } }
        public int Capacity { get; set; }

        public bool IsCleaned {  get; set; }

        public IList<Animal> Animals { get; set; }
        public Cage(int capacity, bool isCleaned, IList<Animal> animals)
        {
            Number = 0;
            Capacity = capacity;
            IsCleaned = isCleaned;
            Animals = animals;
        }
        public Cage(int capacity, bool isCleaned) 
        {
            Number = 0;
            Capacity = capacity;
            IsCleaned = isCleaned;
            Animals = new List<Animal>();
        }
        public override string ToString()
        {
            string otwet = "";
            Console.WriteLine($"{Number} {Capacity} {IsCleaned} ");
            foreach ( var animal in Animals )
            {
                otwet += animal;
                otwet += '\n';
            }
            return otwet;
        }
    }
}