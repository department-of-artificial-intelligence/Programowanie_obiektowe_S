using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile:Animal
    {
        public bool _venomus;
       
        public bool Venomus
        {
            get { return _venomus; }
            set { _venomus = value; }
        }


        public Reptile() : base() { }

        public Reptile(string foodType, int legCount, string origin, string spieces, bool venomus) : base(foodType, legCount, origin, spieces)
        {
            _venomus = venomus;
        }




    }





}