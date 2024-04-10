namespace Lab5.BLL
{
    public abstract class Animal : IMovingMethod
    {

        private string _foodType;
        private int _lengsCount;
        private string _origin;
        private string _species;

        public string FoodType { get { return _foodType; } set { _foodType = value; } }
        public int LengthCount { get { return _lengsCount; } set { _lengsCount = value; } }
        public string Origin { get { return _origin; } set { _origin = value; } }
        public string Species { get { return _species; } set { _species = value; } }

        public Animal(string FoodType, int LengthCount, string Origin, string Species)
        {
            _foodType = FoodType;
            _lengsCount = LengthCount;
            _origin = Origin;
            _species = Species;

        }




    }
}