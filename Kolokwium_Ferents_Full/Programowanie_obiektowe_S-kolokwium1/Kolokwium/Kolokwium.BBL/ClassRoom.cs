using System.Text;

namespace Kolokwium.BBL
{
    internal class ClassRoom
    {

        public int Number { get; set; }
        public bool IsClean { get; set; }
        public IList<int> Seats { get; set; }
        public ClassRoom(int number, int maxCapacity, bool isClean)
        {

            Number = number;
            IsClean = isClean;

        }

        public void AddSeat(int seatId)
        {

            Seats.Add(seatId);

        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Number : {Number}");
            sb.AppendLine($"MaxCapacity: {Seats}");
            sb.AppendLine($"IsClean: {IsClean}");

            return sb.ToString();

        }


    }
}
