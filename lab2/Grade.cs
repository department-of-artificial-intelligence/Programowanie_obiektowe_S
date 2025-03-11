namespace lab2
{
    internal class Grade
    {
        private string _subjectName;
        private DateTime _date;
        private double _value;

        public string SubjectName
        {
            get { return _subjectName; }
            set { _subjectName = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public Grade()
        {

        }

        public Grade(string subjectName, double value, DateTime date)
        {

        }

        public override string ToString()
        {
            return $"SubjectName: {SubjectName}, Date: {Date}, Value: {Value}";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
