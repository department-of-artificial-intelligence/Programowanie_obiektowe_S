namespace Lab05.BBL
{
    public class Mammal : Animal
    {
        public string PlaceOfBirth { get; set; }
        public Mammal(string food, int legs, string origin, string species, string place)
            : base(food, legs, origin, species)
        {
            PlaceOfBirth = place;
        }
    }
}