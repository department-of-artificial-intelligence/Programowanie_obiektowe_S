using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    class ClassRoom: IInfo
    {
        public int Number { get; set; }
        public bool IsClean { get; set; }
        public int MaxCapacity {  get; set; }
        public IList <int> Seats { get; set; }
        public ClassRoom(int number,int maxCapacity, bool isClean)
        {
            Number = number;
            MaxCapacity = maxCapacity;
            IsClean = isClean;
            Seats = new List<int>();
        }
        public void AddSeat(int seatId)
        {
            Seats.Add(seatId);
        }
        public override string ToString()
        {
            string res = $"Number; {Number}, MaxCapacity; {MaxCapacity}, Isclean: {IsClean}\nSeats:\n";
            foreach (int seat in Seats)
            {
                res += "\t"+seat +"\n" ;
            }
            return res ;
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
