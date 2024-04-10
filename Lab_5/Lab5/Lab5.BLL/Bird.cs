namespace Lab5.BLL
{
    public class Bird : Animal
    {

        public double Endurance { get; set; }
        public double SpreadWingLegth { get; set; }

        public double FlightDistance => Endurance * SpreadWingLegth;

        public Bird(string FoodType, int LengsCount, string Origin, string Species)
            : base(FoodType, LengsCount, Origin, Species)
        {



        }
    }
}