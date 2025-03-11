namespace Lab2
{
    class Student : Person
    {
        private int _year;
        private int _group;
        private int _IndexId;

        public int Year { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }

        public Student()
        {
            _year = 0;
            _group = 0;
            _IndexId = 0;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) : base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _IndexId = indexId;
        }

        public override string ToString()
        {
            return base.ToString() + $"Year: {_year}, Group: {_group}, Index id: {_IndexId}\n";
        }
    }
}
