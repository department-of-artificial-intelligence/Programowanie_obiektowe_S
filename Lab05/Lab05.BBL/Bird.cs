namespace Lab05.BBL
{
    public class Bird : Animal
    {
        public double Endurance { get; set; }
        public double SpreadWingsLength { get; set; }
        public double FlightDistance => Endurance * SpreadWingsLength;
        public Bird(string food, int legs, string origin,
                    string species, double endurance, double length)
            : base(food, legs, origin, species)
        {
            Endurance = endurance;
            SpreadWingsLength = length;
        }
    }
}