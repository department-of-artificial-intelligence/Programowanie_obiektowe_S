namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        protected string _naturalLivingEnvironment;
        public string? NaturalLivingEnvironment { get; set; }

        public Mammal(string foodType, int legsCount, string origin, string species, string naturalLivingEnvironment) : base(foodType, legsCount, origin, species)
        {
            _naturalLivingEnvironment = naturalLivingEnvironment;
        }

        public override string ToString()
        {
            return base.ToString() + $"Mammal natural living environment : {_naturalLivingEnvironment};\n\n";
        }
    }
}