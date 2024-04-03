using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab05.BLL
{
    public class Cage
    {
        protected int _capacity;
        protected bool _clean;
        protected int _id;
        protected IList<Animal> _animals;
    }
}