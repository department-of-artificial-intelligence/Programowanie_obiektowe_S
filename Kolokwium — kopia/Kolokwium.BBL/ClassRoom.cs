namespace Kolokwium.BBL
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
            MaxCapacity = maxCapacity;
            IsClean = isClean;
            Seats = new List<int>();
        }
        public void AddSeat(int seatId)
        {
            if (Seats.Count < MaxCapacity && !Seats.Contains(seatId))
            {
                Seats.Add(seatId);
            }
        }
        public override string ToString()
        {
            return $"{Number}; {IsClean}; {MaxCapacity}; SeatCount = {Seats.Count}";
        }
        public void Display()
        {
            Console.WriteLine(ToString());
        }
    }
}
