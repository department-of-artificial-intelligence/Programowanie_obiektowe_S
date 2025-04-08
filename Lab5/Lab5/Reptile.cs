namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        protected bool _isPoisonous;
        public bool? IsPoisionous { get; set; }

        public Reptile(string foodType, int legsCount, string origin, string species, bool isPoisonous) : base(foodType, legsCount, origin, species)
        {
            _isPoisonous = isPoisonous;
        }

        public override string ToString()
        {
            return base.ToString() + $"Is reptile poisonous: {(_isPoisonous ? "Yes" : "No")};\n\n";
        }
    }
}