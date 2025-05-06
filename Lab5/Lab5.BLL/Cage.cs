using Generic.Extensions;
using System.Diagnostics.Metrics;

namespace Lab5.BLL
{
    public class Cage:IDisplayable,IContainer
    {
        public static int _counter = 0;
        private int _id;
        private int _size;
        private bool _isCleaningNeed;
        

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public bool IsCleaningNeed
        {
            get { return _isCleaningNeed; }
            set { _isCleaningNeed = value; }
        }

        public IList<Animal> Animals { get; set; } 

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Cage(int size, bool isCleaningNeed, List<Animal> animals)
        {
            _counter++;
            Id = _counter;
            Size = size;
            IsCleaningNeed = isCleaningNeed;
            Animals = animals ?? new List<Animal>();
        }

        public override string ToString()
        {
            string animalList = Animals.Count > 0
                ? string.Join(", ", Animals.Select(a => a.ToString()))
                : "none";
            return $"Cage[Id={Id}]: Size={Size}, IsCleaningNeeded={IsCleaningNeed}, Animals={animalList}";
        }
    }
}