namespace Lab5.BLL
{
    public class Cage
    {
        public static int counter = 0;
        private int _id;
        private int _size;
        private bool _isCleaningNeed;
        private List<Animal> _animals;

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

        public List<Animal> Animals
        {
            get { return _animals; }
            set { _animals = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Cage(int size, bool iscleaningneed, List<Animal> animals)
        {
            counter++;
            Size = size;
            IsCleaningNeed = iscleaningneed;
            Animals = animals;
            Id = counter;
        }

        public override string ToString()
        {
            string a = "";
            foreach (Animal animal in Animals)
            {
                a += animal + ", ";
            }
            return $"Cage[Id={Id}]: Size={Size}, IsCleaningNeeded={IsCleaningNeed}, Animals={a} ";
        }
    }
}