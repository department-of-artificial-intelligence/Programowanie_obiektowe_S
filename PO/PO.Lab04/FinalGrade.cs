namespace PO.Lab04
{
    internal class FinalGrade
    {

        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public FinalGrade(Subject subject, double value, DateTime date)
        {
            Subject = subject;
            Date = date;
            Value = value;
        }

        public override string ToString()
        {
            return $"Subject: {Subject}, Date: {Date}, Value: {Value}";
        }
    }
}
