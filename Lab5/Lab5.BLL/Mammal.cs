namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        private string _environment;

        public string Environment
        {
            get { return _environment; }
            set { _environment = value; }
        }
        public Mammal(string foodType, int legsCount, string origin, string species, string environment) : base(foodType, legsCount, origin, species)
        {
            Environment = environment;

        }
    }
}