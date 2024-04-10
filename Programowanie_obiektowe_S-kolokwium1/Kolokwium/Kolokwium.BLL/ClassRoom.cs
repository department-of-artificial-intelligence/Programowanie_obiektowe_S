using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class ClassRoom
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

        }

        public void AddSeat (int seatId)
        {
            Seats.Add(seatId);
        }

        public override string ToString()
        {
            return $"{Number} {IsClean} {MaxCapacity} {Seats}";
        }
    }
}
