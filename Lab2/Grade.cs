namespace Lab2
{
    class Grade : Student
    {
        private string? _subjectName;
        private DateTime _date;
        private double _value;

        public string? SubjectName { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public Grade()
        {
            _subjectName = "";
            _date = default(DateTime);
            _value = 0.0;
        }

        public Grade(string subjectName, DateTime date, double value)
        {
            _subjectName = subjectName;
            _date = date;
            _value = value;
        }

        public override string ToString()
        {
            return $"Subject name: {_subjectName}, Date: {_date}, Value: {_value}\n";
        }

        public override void Details()
        {
            Console.WriteLine(ToString());
        }
    }
}
