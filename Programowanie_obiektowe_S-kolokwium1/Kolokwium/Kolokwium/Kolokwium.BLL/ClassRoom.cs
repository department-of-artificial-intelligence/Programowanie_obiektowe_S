using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium.BLL
{
    public class ClassRoom : IInfo
    {
        public int Number {  get; set; }
        public bool IsCleaned {  get; set; }
        public int MaxCapacity {  get; set; }
        public IList<int> seats { get; set; }
        public ClassRoom(int number, int maxCapacity, bool isCleaned)
        {
            Number = number;
            IsCleaned = isCleaned;
            MaxCapacity = maxCapacity;
            seats = new List<int>();
        }
        public void AddSeat(int seatid)
        {
            if(seats != null)
            {
                seats.Add(seatid);
            }
        }
        public override string ToString()
        {
            string str = $"ClassRoom, number: {Number} | cleaned? - {IsCleaned} | MaxCap: {MaxCapacity} \n";
            if(seats != null && seats.Count > 0)
            {
                str += ", with seats: \n";
                foreach(var seat in seats)
                    str += seat.ToString() + " ";

                str += "\n";
            }
            return str;
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}