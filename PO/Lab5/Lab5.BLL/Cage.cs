using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;


namespace Lab5.BLL
{
    public class Cage : IDisplayable, IContainer
    {
        private long _Id;
        public bool NeedClean
        {
            get; set;
        }

        public double Capacity
        {
            get; set;
        }
        public long Id
        {
            get { return _Id; }
            set
            {
                Random random = new Random();
                _Id = random.Next(0, 99999999);
            }
        }
        public IList<Animal> Animals { get; set; }

        public Cage(int capac, bool needClean, List<Animal> lista) 
        {
            Capacity = capac;
            NeedClean = needClean;
            Animals = lista;
        }
        public Cage(int capac, bool iscleaned)
        {
            Id = 0;
            Capacity = capac;
            NeedClean = NeedClean;
            Animals = new List<Animal>();
        }
        public override string ToString()
        {
            Console.WriteLine($"Number = {Id},NeedClean = {NeedClean},Capacity = {Capacity}, animalsList: ");
            foreach( var animal in Animals)
            {
                Console.WriteLine(animal.ToString());
            }
            return "";
        }
    }
}


