namespace Lab05.BBL
{
    public abstract class Animal : IMovingMethod
    {
        private string _foodType;
        private int _legsCount;
        private string _origin;
        private string _species;
        public string FoodType { get => _foodType; set => _foodType = value; }
        public int LegsCount { get => _legsCount; set => _legsCount = value; }
        public string Origin { get => _origin; set => _origin = value; }
        public string Species { get => _species; set => _species = value; }
        protected Animal(string food, int legs, string origin, string species)
        {
            _foodType = food;
            _legsCount = legs;
            _origin = origin;
            _species = species;
        }
    }
}