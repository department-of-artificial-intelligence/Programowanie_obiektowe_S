using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class ClassRoom : IInfo
    {
        public int Number { get; set; }
        public bool IsClean { get; set; }
        public int MaxCapacity { get; set; }
        public IList<int> Seats { get; set; }
        public ClassRoom(int number, int maxCapacity, bool isClean)
        {
            Number = number;
            IsClean = isClean;
            MaxCapacity = maxCapacity;
            Seats = new List<int>();
        }
        public void AddSeat(int seatId) {  Seats.Add(seatId); }
        public override string ToString()
        {
            var result = $"Classroom #{Number}, isClean: {IsClean}, maximum capacity: {MaxCapacity}\nList of seats:\n";
            foreach (var seat in Seats) { result += seat.ToString() + '\n'; }
            return result;
        }
        public void Display() { Console.WriteLine(ToString()); }
    }
}
