namespace Lab05.BBL
{
    public class Reptile : Animal
    {
        public bool IsVenomous { get; set; }
        public Reptile(string food, int legs, string origin, string species, bool isVenomous)
            : base(food, legs, origin, species)
        {
            IsVenomous = isVenomous;
        }
    }
}