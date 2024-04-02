using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Cage : IContainer
    {
        
        private int _pojemnosc;
        private bool _sprzotanie;
        private int _id;

        public bool IsPrzotanie { get {  return _sprzotanie; } set { _sprzotanie = value; } }

        public int Pojemnosc {  get { return _pojemnosc;} set { _pojemnosc = value; } }

        public IList<Animal> Animals { get; set; }

        public int Id { get { return _id; } set {
            Random random= new Random();
                
                _id= random.Next(1, 100);
            } }

        public Cage(int cap, bool iscleaned, List<Animal> animals)
        {
            Id = 0;
            Pojemnosc = cap;
            IsPrzotanie = iscleaned;
            if (animals.Count < cap || animals.Count < Pojemnosc)
            {
                Animals = animals;
            }
            else
            {
                Console.WriteLine("Too much animals! Cage overflow");
            }
        }

        public override string ToString()
        {
            string res = $"Cages -> Id:{Id}, Pojemnosc: {Pojemnosc} , Sprzotanie:{IsPrzotanie},Animals: ";
            if (Animals != null) { 
            foreach (var animal in Animals)
                res += "\n" + animal + "\n";
            return res;
            } else
            {
                return "Nie ma zwirzat";
            }
        }
    }
}