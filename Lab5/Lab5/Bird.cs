namespace Lab5.BLL
{
    public class Bird : Animal
    {
        protected double _wingspan;
        protected double _endurance;
        public double? Wingspan { get; set; }
        public double? Endurance { get; set; }

        public Bird(string foodType, int legsCount, string origin, string species, double wingspan, double endurance) : base(foodType, legsCount, origin, species)
        {
            _wingspan = wingspan;
            _endurance = endurance;
        }

        public void Fly()
        {
            Console.WriteLine($"Maksymalna długośc lotu = {_wingspan * _endurance}\n");
        }

        public override string ToString()
        {
            return base.ToString() + $"Bird wingspan: {_wingspan};\nEndurance {_endurance};\n\n";
        }
    }
}