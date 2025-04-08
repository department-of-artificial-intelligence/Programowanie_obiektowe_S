namespace Lab5.BLL
{
    public class Animal : IMovingMethod
    {
        protected string _foodType;
        protected int _legsCount;
        protected string _origin;
        protected string _species;

        public int LegsCount { get { return _legsCount; } set { _legsCount = value; } }

        public string FoodType
        {
            get { return _foodType; }
            set { _foodType = value; }
        }

        public string Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }
        public Animal(string foodType, int legsCount, string origin, string species)
        {
            FoodType = foodType;
            LegsCount = legsCount;
            Origin = origin;
            Species = species;
        }

        public override string ToString()
        {
            return Species;
        }


    }
}