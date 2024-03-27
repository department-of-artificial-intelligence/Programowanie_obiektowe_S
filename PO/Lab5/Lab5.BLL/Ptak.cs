using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal
    {

        public float Wingspan
        {
            get => default;
            set
            {
            }
        }

        public int Resilience
        {
            get => default;
            set
            {
            }
        }

        public void Fly()
        {
            throw new System.NotImplementedException();
        }
    }
}