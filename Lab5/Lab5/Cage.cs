namespace Lab5.BLL
{
    public class Cage
    {
        protected int _capacity;
        protected bool _isDirty;
        protected List<Animal> _animals;
        public int? Capacity { get; set; }
        public bool IsDirty { get; set; }
        public List<Animal> Animals => _animals;

        public Cage(int capacity, bool isDirty)
        {
            _capacity = capacity;
            _isDirty = isDirty;
            _animals = new List<Animal>();
        }

        public Cage(int capacity, bool isDirty, List<Animal> animals)
        {
            _capacity = capacity;
            _isDirty = isDirty;
            _animals = animals;
        }

        public override string ToString()
        {
            string animalsFromCage = "";
            if (_animals != null)
                foreach (var animal in _animals)
                    animalsFromCage += animal.ToString();
            return $"Cage capacity: {_capacity};\nIs cage dirty: {(_isDirty ? "Yes" : "No")};\n\nAnimals in cage:\n\n{animalsFromCage}";
        }
    }
}