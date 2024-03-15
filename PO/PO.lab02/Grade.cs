namespace PO.lab02
{
    internal class Grade
    {
        private string _subjectName = null!;
        private DateTime _date;
        private double _value;

        public string SubjectName { get => _subjectName; set => _subjectName = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public double Value { get => _value; set => _value = value; }

        public Grade()
        {
            SubjectName = string.Empty;
            Date = DateTime.MinValue;
            Value = 0;
        }

        public Grade(string subjectName, double value, DateTime date)
        {
            SubjectName = subjectName;
            Date = date;
            Value = value;
        }

        public override string ToString()
        {
            return $"\tGrade | Subject: {SubjectName}, Date: {Date}, Grade: {Value}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
