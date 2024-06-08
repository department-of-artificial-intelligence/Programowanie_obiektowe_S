using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    internal class ClassRoom : IInfo
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
            string s = new string($"Number: {Number} IsClean?: {IsClean} MaxCapacity: {MaxCapacity} Seats: \n");
            foreach (var item in Seats)
            {
                s += item.ToString();
            }
            return s;
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }
    }
}
