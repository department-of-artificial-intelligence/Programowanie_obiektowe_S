using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przygotowanie.BLL
{
    public class ClassRoom : IInfo
    {
        public int Number { get; set; }
        public bool IsClean { get; set; }
        public int MaxCapacity { get; set; }
        public IList<int> Seats { get; set; }
        public ClassRoom(int number, bool isClean, int maxCapacity, IList<int> seats)
        {
            Number = number;
            IsClean = isClean;
            MaxCapacity = maxCapacity;
            Seats = seats;
        }

        public void AddSeat(int seatId)
        {
            Seats.Add(seatId);
        }

        public override string ToString()
        {
            var str = $"Number: {Number}, IsClean: {IsClean}, Max Capacity: {MaxCapacity}";
            str += string.Join<int>('\n', Seats);
            return str;
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
