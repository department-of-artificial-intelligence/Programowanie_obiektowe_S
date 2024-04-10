namespace Kolokwium.BBL
{
    internal class Student : Person
    {

        public int Year { get; }
        public int Group { get; }
        public int IndexId { get; }

        public Student(string firstName, string lastName, int year, int group, int indexId)
            : base(firstName, lastName)
        {

            Year = year;
            Group = group;
            IndexId = indexId;

        }

        public override string ToString()
        {
            return $"Studen | {base.ToString()}";
        }


    }
}
