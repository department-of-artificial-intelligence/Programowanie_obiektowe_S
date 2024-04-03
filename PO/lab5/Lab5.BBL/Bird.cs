using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BBL
{
    public class Bird : Animal
    {

        public int Endurance
        {
            get; set;
        }

        public float Wingspan
        {
            get; set;
        }

        public Bird(string name,int numberOfLegs,string nutrition,string origin,int endurance,float wingspan) : base(name,numberOfLegs,nutrition,origin)
        {
            Endurance = endurance;
            Wingspan = wingspan;
        }

        public void fly()
        {
            throw new System.NotImplementedException();
        }
    }
}