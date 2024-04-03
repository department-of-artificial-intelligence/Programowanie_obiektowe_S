namespace Lab5.BLL
{
    public class Bird : Animal
    {
        private int _stamina;
        private double _wingspan;

        public Bird(string species, string foodType, string origin, double wingspan, int stamina) : base(species, foodType, origin)
        {
            _wingspan = wingspan;
            _stamina = stamina;
        }

        public double Fly()
        {
            throw new System.NotImplementedException();
        }
    }
}