using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    public interface IClonable<T>
    {
        T Clone();
    }

    class Klasa<T> where T: class, new()
    {
        public T Wartosc { get; set; }

        public Klasa()
        {
            this.Wartosc = null;
        }

        public Klasa(T wartosc)
        {
            this.Wartosc = wartosc;
        }

        public T NowaWartosc()
        {
            return new T();
        }

        public T Orginal()
        {
            return this.Wartosc;
        }
    }

    
}


