namespace Lab5.BLL
{
    public class Bird : Animal
    {
        private double _wingWidth;
        private int _strength;

        public double WingWidth
        {
            get { return _wingWidth; }
            set { _wingWidth = value; }
        }

        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }

        public Bird(string foodType, int legsCount, string origin, string species, double wingWidth, int strength) : base(foodType, legsCount, origin, species)
        {
            WingWidth = wingWidth;
            Strength = strength;
        }

        public double Fly()
        {
            return WingWidth * Strength;
        }

    }



}