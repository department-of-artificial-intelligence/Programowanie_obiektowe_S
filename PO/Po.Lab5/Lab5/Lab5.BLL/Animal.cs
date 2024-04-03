namespace Lab5.BLL
{
    public class Animal
    {
        public string _foodType { get; set; }
        public int _legsCount { get; set; }
        public string _origin { get; set; }
        public string _species { get; set; }

        public Animal()
        {
            _foodType = "nieznany";
            _legsCount = 0;
            _origin = "nieznany";
            _species = "nieznany";
        }

        public Animal(string foodType, int legsCount, string origin, string species)
        {
            _foodType = foodType;
            _legsCount = legsCount;
            _origin = origin;
            _species = species;
        }
    }
}