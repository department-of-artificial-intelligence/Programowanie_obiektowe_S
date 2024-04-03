namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        private string _environment;

        public Mammal(string species, string foodType, string origin, string environment) : base(species, foodType, origin)
        {
            _environment = environment;
        }
    }
}