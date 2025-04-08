using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        private double _rozpietoscSkrzydel {  get; set; }
        private double _wytrzymalosc {  get; set; }

        public Bird() { }

        public double Fly(double _rozpietoscSkrzydel, double _wytrzymalosc)
        {
            throw new System.NotImplementedException();
        }
    }
}