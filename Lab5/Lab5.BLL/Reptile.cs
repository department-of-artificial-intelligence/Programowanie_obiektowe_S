namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        private bool _isVenomous;

        public bool IsVenomous
        {
            get { return _isVenomous; }
            set { _isVenomous = value; }
        }

        public Reptile(string foodType, int legsCount, string origin, string species, bool isVenomous) : base(foodType, legsCount, origin, species)
        {
            IsVenomous = isVenomous;
        }
    }
}