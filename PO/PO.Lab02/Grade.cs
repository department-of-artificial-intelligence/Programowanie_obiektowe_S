namespace PO.Lab02
{
    internal class Grade
    {
        private string _subjectName;
        private DateTime _date;
        private double _value;

        public string SubjectName
        {
            get { return  _subjectName; }
            set { _subjectName = value; }
        }

        public DateTime Date
        {
            get { return _date; } 
            set {  _date = value; }
        }

        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public Grade()
        {
            _subjectName = "nieznana";
            _date = DateTime.Now;
            _value = 0;
        }

        public Grade(string subjectName, double value, DateTime date)
        {
            _subjectName = subjectName;
            _value = value;
            _date = date;
        }

        public override string ToString()
        {
            return $"Grade | Subject name: {_subjectName}, Date: {_date}, Value: {_value}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
