namespace Lab5.BLL
{
    public abstract class Animal
    {
        protected string _species;
        protected string _foodType;
        protected string _origin;

        public Animal(string species, string foodType, string origin)
        {
            _species = species;
            _foodType = foodType;
            _origin = origin;
        }
    }
}