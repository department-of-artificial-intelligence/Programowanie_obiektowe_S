using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    
    class Para
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Para()
        {
            X = 0;
            Y = 0;
        }

        public Para(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Add()
        {
            return X + Y;
        }
    }

    class Para <T> where T: INumber<T>
    {
        public required T X { get; set; }
        public required T Y { get; set; }

        public Para()
        {
            X = T.Zero;
            Y = T.Zero;
        }

        public Para(T x, T y)
        {
            X = x;
            Y = y;
        }

        public T Add()
        {
            return X + Y;
        }
    }
    
}
