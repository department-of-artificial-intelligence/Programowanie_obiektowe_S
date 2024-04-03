namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        private bool _venomous;

        public Reptile(string species, string foodType, string origin, bool venomous) : base(species, foodType, origin)
        {
            _venomous = venomous;
        }
    }
}