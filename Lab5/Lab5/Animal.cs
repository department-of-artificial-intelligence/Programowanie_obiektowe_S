

namespace Lab5.BLL
{
    public class Animal
    {
        protected string _foodType;
        protected int _legsCount;
        protected string _origin;
        protected string _species;

        public string? FoodType { get; set; }
        public int? LegsCount { get; set; }
        public string? Origin { get; set; }
        public string? Species { get; set; }

        public Animal(string foodType, int legsCount, string origin, string species)
        {
            _foodType = foodType;
            _legsCount = legsCount;
            _origin = origin;
            _species = species;
        }

        public override string ToString()
        {
            return $"Animal food type: {_foodType};\nLegs count: {_legsCount};\nOrigin: {_origin};\nSpecies: {_species};\n";
        }

		public void Print()
		{
            Console.WriteLine(ToString());
		}
	}
}